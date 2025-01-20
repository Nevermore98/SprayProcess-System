using AntdUI;
using Mapster;
using Masuit.Tools;
using Microsoft.Extensions.DependencyInjection;
using MiniExcelLibs;
using SprayProcessSystem.BLL.Dto.DataDto;
using SprayProcessSystem.BLL.Managers;
using SprayProcessSystem.Model;
using SprayProcessSystem.Model.Entities;
using System.Diagnostics;

namespace SprayProcessSystem.UI.Views
{
    public partial class ViewReportManage : UserControl
    {
        private AntList<DataEntity> _dataList = new();
        private readonly DataManager _dataManager;
        private DateTime _startDate;
        private DateTime _endDate;
        private int _currentPage = 1;
        private int _pageSize = 20; 

        public ViewReportManage()
        {
            InitializeComponent();
            _dataManager = Program.ServiceProvider.GetRequiredService<DataManager>();
            InitControls();
        }

        private void InitControls()
        {
            table_data.RowHeight = 40;
            table_data.Columns = new ColumnCollection()
            {
                new Column("Index", "序号", ColumnAlign.Center)
                {
                    Width="60",
                    SortOrder = true
                },
                new Column("CreatedAt", "时间", ColumnAlign.Center)
                {
                    Width="150",
                    SortOrder = true
                },
            };
            foreach (var item in Global.DataNameChToEnDict)
            {
                table_data.Columns.Add(
                    new Column(item.Value, item.Key, ColumnAlign.Center)
                    {
                        Width = "140",
                        SortOrder = false
                    });
            }

            dpr_dataDateRange.MaxDate = DateTime.Today.AddDays(1);
            pag_data.PageSize = _pageSize;
            pag_data.Current = _currentPage;
        }


        private void dpr_dataDateRange_PresetsClickChanged(object sender, AntdUI.ObjectNEventArgs e)
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

            dpr_dataDateRange.Value = new DateTime[] { _startDate, _endDate };
        }


        private void dpr_dataDateRange_ValueChanged(object sender, DateTimesEventArgs e)
        {
            _startDate = e.Value[0];
            _endDate = e.Value[1].AddDays(1).AddMilliseconds(-1);
        }

        private async void btn_query_Click(object sender, EventArgs e)
        {
            if (dpr_dataDateRange.Value == null)
            {
                Generic.ShowMessage(this.ParentForm, "请选择时间范围", TType.Warn, false);
                return;
            }
            _dataList.Clear();
            btn_query.Loading = true;
            btn_query.Text = "查询中...";
            DataQueryDto dataQueryDto = new DataQueryDto() { StartTime = _startDate, EndTime = _endDate };
            var queryDataResult = await _dataManager.QueryDataAsync(dataQueryDto);
            if (queryDataResult.Result == Constants.Result.Success)
            {
                var dataList = queryDataResult.Data;
                if(dataList.Count == 0)
                {
                    Generic.ShowMessage(this.ParentForm, "未查询到数据", TType.Warn, false);
                    btn_query.Loading = false;
                    btn_query.Text = "查询";
                    return;
                }
                _dataList.AddRange(dataList.Select(x => x.Adapt<DataEntity>()).ToArray());

                pag_data.Total = _dataList.Count;
                pag_data.PageSize = _pageSize;
                pag_data.Current = _currentPage;
            }

            int startIndex = (_currentPage - 1) * _pageSize;
            int endIndex = Math.Min(startIndex + _pageSize, _dataList.Count);
            var pagedList = new AntList<DataEntity>(_dataList.Skip(startIndex).Take(_pageSize).ToList());
            table_data.Binding(pagedList);

            btn_query.Loading = false;
            btn_query.Text = "查询";
        }

        private async void btn_export_Click(object sender, EventArgs e)
        {
            if (_dataList.Count == 0)
            {
                Generic.ShowMessage(this.ParentForm, "暂无数据", TType.Warn, false);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel 文件(*.xlsx)|*.xlsx";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = saveFileDialog.FileName;
                    btn_export.Loading = true;
                    btn_export.Text = "导出中...";
                    await MiniExcel.SaveAsAsync(filePath, _dataList);
                    btn_export.Loading = false;
                    btn_export.Text = "导出";
                    Generic.AppendLog($"导出数据报表成功", Constants.LogLevelEnum.Info, true);

                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = saveFileDialog.FileName,
                        UseShellExecute = true
                    };
                    Process process = new Process
                    {
                        StartInfo = startInfo
                    };
                    process.Start();
                }
                catch (Exception ex)
                {
                    Generic.AppendLog($"导出数据报表失败：{ex.Message}", Constants.LogLevelEnum.Error, true);
                    btn_export.Loading = false;
                    btn_export.Text = "导出";
                }
            }
        }

        private void pag_data_ValueChanged(object sender, PagePageEventArgs e)
        {
            if (_dataList.Count == 0) return;
            if (e.PageSize != _pageSize)
            {
                _currentPage = 1;
                pag_data.Current = 1;
            }
            else
            {
                _currentPage = e.Current;
            }
            _pageSize = e.PageSize;

            int startIndex = (_currentPage - 1) * _pageSize;
            int endIndex = Math.Min(startIndex + _pageSize, _dataList.Count);

            var pagedList = new AntList<DataEntity>(_dataList.Skip(startIndex).Take(_pageSize).ToList());
            table_data.Binding(pagedList);
        }
    }
}
