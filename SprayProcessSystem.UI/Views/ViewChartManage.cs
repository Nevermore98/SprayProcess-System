using AntdUI;
using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using Mapster;
using Masuit.Tools.Reflection;
using Microsoft.Extensions.DependencyInjection;
using SkiaSharp;
using SprayProcessSystem.BLL.Dto.DataDto;
using SprayProcessSystem.BLL.Managers;
using SprayProcessSystem.Model;
using SprayProcessSystem.Model.Entities;
using System.Collections.ObjectModel;
using System.Globalization;
using Button = AntdUI.Button;
using Label = AntdUI.Label;

namespace SprayProcessSystem.UI.Views
{
    public partial class ViewChartManage : UserControl
    {
        private readonly DataManager _dataManager;
        private DateTime _startDate;
        private DateTime _endDate;
        private List<DataEntity> _dataList = new();
        private bool _isLegendColorSetFinished = false;
        private Dictionary<string, Color> _seriesToColorDict = new();

        public ViewChartManage()
        {
            InitializeComponent();

            _dataManager = Program.ServiceProvider.GetRequiredService<DataManager>();

            InitControls();
        }

        private void InitControls()
        {
            lineChart_data.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.Both;

            lineChart_data.TooltipTextSize = 16;
            //lineChart_data.TooltipTextPaint = viewModel.TooltipTextPaint, 
            //lineChart_data.TooltipBackgroundPaint = viewModel.TooltipBackgroundPaint, 
            lineChart_data.TooltipPosition = LiveChartsCore.Measure.TooltipPosition.Left;

        }

        private async void UpdateChart()
        {
            var seriesCollection = new ObservableCollection<ISeries>();

            var properties = new Dictionary<string, Func<DataEntity, double?>>
            {
                { "脱脂pH值", x => ConvertToDouble(x.DegreasingPH) },
                { "陶化pH值", x => ConvertToDouble(x.PhosphatingPH) },
                { "脱脂喷淋泵压力值", x => ConvertToDouble(x.DegreasingSprayPumpPressure) },
                { "粗洗喷淋泵压力值", x => ConvertToDouble(x.RoughWashSprayPumpPressure) },
                { "陶化喷淋泵压力值", x => ConvertToDouble(x.PhosphatingSprayPumpPressure) },
                { "精洗喷淋泵压力值", x => ConvertToDouble(x.FineWashSprayPumpPressure) },
                { "水分炉测量温度", x => ConvertToDouble(x.WaterStoveTemperature) },
                { "固化炉测量温度", x => ConvertToDouble(x.SolidifyStoveTemperature) },
                { "厂内温度", x => ConvertToDouble(x.FactoryTemperature) },
                { "厂内湿度", x => ConvertToDouble(x.FactoryHumidity) },
            };

            // 如果 properties 中的 key 不在 DataNeedSaveList 中，则移除
            foreach (var key in properties.Keys)
            {
                if (!Global.DataNeedSaveList.Contains(key))
                {
                    properties.Remove(key);
                }
            }

            panel_legend.Controls.Clear();
            var labelList = new List<Control>();
            foreach (var property in properties)
            {
                if (property.Value == null) continue;
                var values = _dataList
                    .OrderBy(x => x.CreatedAt)
                    .Select(x => property.Value(x))
                    .ToList();

                var createdAtValues = _dataList
                    .OrderBy(x => x.CreatedAt)
                    .ToList();

                if (values.Count > 0)
                {
                    seriesCollection.Add(new LineSeries<double?>
                    {
                        Values = values,
                        Fill = null,
                        LineSmoothness = 0,
                        GeometrySize = 4,

                        Name = property.Key,
                    });
                }

                var currentSeries = seriesCollection.Last() as LineSeries<double?>;
                var button = new Button()
                {
                    Text = property.Key,
                    BackColor = Color.LightGray,
                    ForeColor = Color.White,
                    Width = 70,
                    Height = 50,
                    Radius = 6,
                    Padding = new Padding(8, 4, 8, 4),
                    Margin = new Padding(4),
                    Cursor = Cursors.Hand,
                    Dock = DockStyle.Top
                };

                button.Click += (s, e) =>
                {
                    currentSeries.IsVisible = !currentSeries.IsVisible;
                    if (!currentSeries.IsVisible)
                    {
                        // TODO 保存到字典
                        button.BackColor = Color.LightGray;
                    }
                    else
                    {
                        button.BackColor = _seriesToColorDict[button.Text];
                    }
                };

                labelList.Insert(0, button);
            }

            panel_legend.Controls.AddRange(labelList.ToArray());

            lineChart_data.LegendPosition = LegendPosition.Left;
            lineChart_data.Series = seriesCollection;
            lineChart_data.XAxes = new List<Axis>
            {
                new Axis
                {
                    Labels = _dataList.OrderBy(x => x.CreatedAt).Select(x => x.CreatedAt.ToString("MM-dd HH:mm:ss")).ToList(),
                    LabelsRotation = 30,
                    CrosshairLabelsBackground = SKColors.DarkOrange.AsLvcColor(),
                    CrosshairLabelsPaint = new SolidColorPaint(SKColors.DarkRed),
                    CrosshairPaint = new SolidColorPaint(SKColors.DarkOrange, 1),
                }
            };

            lineChart_data.YAxes = new List<Axis>
            {
                new Axis
                {
                    CrosshairLabelsBackground = SKColors.DarkOrange.AsLvcColor(),
                    CrosshairLabelsPaint = new SolidColorPaint(SKColors.DarkRed),
                    CrosshairPaint = new SolidColorPaint(SKColors.DarkOrange, 1),
                    CrosshairSnapEnabled = true
                }
            };

            lineChart_data.UpdateFinished += (e) =>
            {
                if (_isLegendColorSetFinished) return;
                foreach (var item in panel_legend.Controls)
                {
                    if (item is Button button)
                    {
                        // TODO
                        var index = panel_legend.Controls.IndexOf(button);
                        var series = lineChart_data.Series.Reverse().ToArray()[index] as LineSeries<double?>;
                        var stroke = series.Stroke;
                        SKColor skColor = (SKColor)series.Stroke.GetField("Color");
                        var color = Color.FromArgb(skColor.Alpha, skColor.Red, skColor.Green, skColor.Blue);
                        button.BackColor = color;
                        _seriesToColorDict.Add(button.Text, color);
                    }
                }
                _isLegendColorSetFinished = true;
            };
        }

        private double? ConvertToDouble(string? value)
        {
            if (double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
            {
                return result;
            }

            return null;
        }

        private void dpr_chartDateRange_ValueChanged(object sender, DateTimesEventArgs e)
        {
            _startDate = e.Value[0];
            _endDate = e.Value[1].AddDays(1).AddMilliseconds(-1);
        }

        private async void btn_query_Click(object sender, EventArgs e)
        {
            if (dpr_chartDateRange.Value == null)
            {
                Generic.ShowMessage(this.ParentForm, "请选择时间范围", TType.Warn, false);
                return;
            }
            _dataList.Clear();
            btn_query.Loading = true;
            btn_query.Text = "查询中...";
            _isLegendColorSetFinished = false;

            try
            {
                DataQueryDto dataQueryDto = new DataQueryDto() { StartTime = _startDate, EndTime = _endDate };
                var queryDataResult = await _dataManager.QueryDataAsync(dataQueryDto);
                if (queryDataResult.Result == Constants.Result.Success)
                {
                    var dataList = queryDataResult.Data;
                    if (dataList.Count == 0)
                    {
                        Generic.ShowMessage(this.ParentForm, "未查询到数据", TType.Warn, false);
                        btn_query.Loading = false;
                        btn_query.Text = "查询";
                        return;
                    }
                    _dataList = dataList.Adapt<List<DataEntity>>();
                    UpdateChart();
                }
            }
            finally
            {
                btn_query.Loading = false;
                btn_query.Text = "查询";
            }
        }

        private void dpr_chartDateRange_PresetsClickChanged(object sender, ObjectNEventArgs e)
        {
            DateTime today = DateTime.Today;
            string str = e.Value.ToString();
            switch (str)
            {
                case "今天":
                    _startDate = today;
                    _endDate = today.AddDays(1).AddMilliseconds(-1);
                    break;
                case "近三天":
                    _startDate = today.AddDays(-2);
                    _endDate = today.AddDays(1).AddMilliseconds(-1);
                    break;
                case "近一周":
                    _startDate = today.AddDays(-6);
                    _endDate = today.AddDays(1).AddMilliseconds(-1);
                    break;
                case "近一月":
                    _startDate = today.AddMonths(-1).AddDays(1);
                    _endDate = today.AddDays(1).AddMilliseconds(-1);
                    break;
                case "近三月":
                    _startDate = today.AddMonths(-3).AddDays(1);
                    _endDate = today.AddDays(1).AddMilliseconds(-1);
                    break;
                case "近半年":
                    _startDate = today.AddMonths(-6).AddDays(1);
                    _endDate = today.AddDays(1).AddMilliseconds(-1);
                    break;
                case "近一年":
                    _startDate = today.AddYears(-1).AddDays(1);
                    _endDate = today.AddDays(1).AddMilliseconds(-1);
                    break;
                default:
                    return;
            }

            dpr_chartDateRange.Value = new DateTime[] { _startDate, _endDate };
        }
    }
}
