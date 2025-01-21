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
        private List<Control> _legendButtonList = new();

        public ViewChartManage()
        {
            InitializeComponent();

            _dataManager = Program.ServiceProvider.GetRequiredService<DataManager>();

            InitControls();
        }

        private void InitControls()
        {
            lineChart_data.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X;

            lineChart_data.TooltipTextSize = 16;
            lineChart_data.TooltipPosition = LiveChartsCore.Measure.TooltipPosition.Left;
            //lineChart_data.LegendPosition = LegendPosition.Left;

            panel_legend.Resize += (s, e) =>
            {
                var totalButtonsHeight = _legendButtonList.Sum(b => b.Height + b.Margin.Top + b.Margin.Bottom);
                var verticalPadding = Math.Max((panel_legend.Height - totalButtonsHeight) / 2, 0);
                panel_legend.Padding = new Padding(
                    panel_legend.Padding.Left,
                    verticalPadding,
                    panel_legend.Padding.Right,
                    0
                );
            };

            lineChart_data.UpdateFinished += (e) =>
            {
                if (_isLegendColorSetFinished) return;
                foreach (var item in panel_legend.Controls)
                {
                    if (item is Button button)
                    {
                        var index = panel_legend.Controls.IndexOf(button);
                        var series = lineChart_data.Series.Reverse().ToArray()[index] as LineSeries<double?>;
                        var stroke = series.Stroke;
                        SKColor skColor = (SKColor)series.Stroke.GetField("Color");
                        var color = Color.FromArgb(skColor.Alpha, skColor.Red, skColor.Green, skColor.Blue);
                        button.BackColor = color;

                        _seriesToColorDict.Add(button.Text, color);
                        // 按下背景色加深
                        button.BackActive = ControlPaint.Dark(color, 0.1f);
                        // 悬浮背景色加浅
                        button.BackHover = ControlPaint.Light(color, 0.25f);
                    }
                }
                _isLegendColorSetFinished = true;
            };
        }

        private async void UpdateChart()
        {
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
            _legendButtonList.Clear();
            _seriesToColorDict.Clear();

            _legendButtonList = new List<Control>();
            var seriesCollection = new ObservableCollection<ISeries>();

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
                    Type = TTypeMini.Primary,
                    Width = 70,
                    Height = 40,
                    Radius = 6,
                    WaveSize = 1,
                    Padding = new Padding(8, 4, 8, 4),
                    Margin = new Padding(0, 4, 0, 4),
                    Cursor = Cursors.Hand,
                    Dock = DockStyle.Top
                };

                button.Click += (s, e) =>
                {
                    currentSeries.IsVisible = !currentSeries.IsVisible;
                    if (!currentSeries.IsVisible)
                    {
                        button.BackColor = Color.LightGray;
                        button.BackActive = ControlPaint.Dark(Color.LightGray, 0.1f);
                        button.BackHover = ControlPaint.Light(Color.LightGray, 0.25f);
                    }
                    else
                    {
                        button.BackColor = _seriesToColorDict[button.Text];
                        button.BackActive = ControlPaint.Dark((Color)button.BackColor, 0.1f);
                        button.BackHover = ControlPaint.Light((Color)button.BackColor, 0.25f);
                    }
                };

                _legendButtonList.Insert(0, button);
            }

            panel_legend.Controls.AddRange(_legendButtonList.ToArray());

            int totalButtonsHeight = _legendButtonList.Sum(b => b.Height + b.Margin.Top + b.Margin.Bottom);
            int verticalPadding = Math.Max((panel_legend.Height - totalButtonsHeight) / 2, 0);

            panel_legend.Padding = new Padding(
                panel_legend.Padding.Left,
                verticalPadding,
                panel_legend.Padding.Right,
                0
            );

            lineChart_data.Series = seriesCollection;

            var themeColor = Color.FromArgb(64, 158, 255);
            var skThemeColor = new SKColor((uint)themeColor.ToArgb());

            lineChart_data.XAxes = new List<Axis>
            {
                new Axis
                {
                    Labels = _dataList.OrderBy(x => x.CreatedAt).Select(x => x.CreatedAt.ToString("MM-dd HH:mm:ss")).ToList(),
                    LabelsRotation = 30,
                    CrosshairLabelsBackground = SKColors.WhiteSmoke.AsLvcColor(),
                    CrosshairLabelsPaint = new SolidColorPaint(skThemeColor),
                    CrosshairPaint = new SolidColorPaint(skThemeColor, 1),
                    CrosshairSnapEnabled = true
                }
            };

            lineChart_data.YAxes = new List<Axis>
            {
                new Axis
                {
                    CrosshairLabelsBackground = SKColors.WhiteSmoke.AsLvcColor(),
                    CrosshairLabelsPaint = new SolidColorPaint(skThemeColor),
                    CrosshairPaint = new SolidColorPaint(skThemeColor, 1),
                    CrosshairSnapEnabled = true
                }
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
