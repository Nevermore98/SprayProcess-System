using AntdUI;
using Masuit.Tools;
using MiniExcelLibs;
using SprayProcessSystem.Model;
using SprayProcessSystem.UI.Models;
using System.Data;
using System.Diagnostics;

namespace SprayProcessSystem.UI.Views
{
    public partial class ViewLogManage : UserControl, IDisposable
    {
        private string _logDir;
        private string _currentYearMonth;
        private string _currentDay;
        private string _currentLevel;
        private AntList<Log> _logList = new();
        private string _currentLogLines;

        public ViewLogManage()
        {
            InitializeComponent();
            BindEvents();
            InitControls();
        }

        private void BindEvents()
        {
            cmb_yearMonth.SelectedValueChanged += cmb_yearMonth_SelectedIndexChanged;
            cmb_day.SelectedValueChanged += cmb_day_SelectedIndexChanged;
            cmb_level.SelectedValueChanged += cmb_level_SelectedIndexChanged;

            btn_openDir.Click += btn_openDir_Click;
            btn_exportTxt.Click += btn_exportTxt_Click;
            btn_exportExcel.Click += btn_exportExcel_Click;
        }

        private void InitControls()
        {
            cmb_yearMonth.Items.Clear();
            cmb_day.Items.Clear();
            cmb_level.Items.Clear();

            AppConfig.Current.Load();
            _logDir = AppConfig.Current.Log.Dir;

            var yearMonthDirList = Directory.GetDirectories(_logDir);
            cmb_yearMonth.Items.AddRange(yearMonthDirList.Select(x => Path.GetFileName(x)).ToArray());

            cmb_yearMonth.SelectedIndex = cmb_yearMonth.Items.Count - 1;
            cmb_day.SelectedIndex = cmb_day.Items.Count - 1;
            cmb_level.SelectedIndex = 0;

            table_log.Binding(_logList);
            table_log.RowHeight = 40;
            table_log.Columns = new ColumnCollection() {
                new Column("Index", "序号", ColumnAlign.Center)
                {
                    Width="60",
                    SortOrder = true
                },
                new Column("Time", "时间", ColumnAlign.Center)
                {
                     Width="120",
                     SortOrder = true
                },
                new Column("LevelTag", "级别", ColumnAlign.Center){
                    Width = "60",
                    SortOrder = false
                },
                // Table 修改 RowHeight 行高后，中文无法显示，需要修改表格的 Gap
                new Column("Content", "内容", ColumnAlign.Center)
                {
                    Align  = ColumnAlign.Left,
                },
            };
        }


        private void cmb_yearMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_yearMonth.SelectedValue == null) return;
            _currentYearMonth = cmb_yearMonth.SelectedValue.ToString();
            var yearMonth = cmb_yearMonth.SelectedValue.ToString();
            var dayDirList = Directory.GetDirectories(Path.Combine(_logDir, yearMonth));
            cmb_day.Items.Clear();
            cmb_day.SelectedIndex = -1;
            // Substring(5) 去除开头的年份-
            cmb_day.Items.AddRange(dayDirList.Select(x => Path.GetFileName(x).Substring(5)).ToArray());
        }

        private void cmb_day_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_day.SelectedValue == null) return;
            _currentDay = $"{_currentYearMonth.Split("-")[0]}-{cmb_day.SelectedValue}";
            cmb_level.Items.Clear();
            cmb_level.SelectedIndex = -1;
            var dayDir = Path.Combine(_logDir, _currentYearMonth, _currentDay);
            Directory.GetFiles(dayDir).ToList().ForEach(x =>
            {
                var level = Path.GetFileNameWithoutExtension(x).Split("-")[3];
                cmb_level.Items.Add(level);
            });
            cmb_level.SelectedIndex = 0;
        }

        private async void cmb_level_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_level.SelectedValue == null) return;
            _logList?.Clear();
            _currentLogLines = string.Empty;
            _currentLevel = cmb_level.SelectedValue.ToString();

            var level = cmb_level.SelectedValue.ToString();
            var dayDir = Path.Combine(_logDir, _currentYearMonth, _currentDay);
            var logFilePath = Directory.GetFiles(dayDir).FirstOrDefault(x => Path.GetFileNameWithoutExtension(x).Contains(level));

            try
            {
                using var fileStream = new FileStream(logFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using var sr = new StreamReader(fileStream, bufferSize: 65536); // 增加缓冲区大小

                var logs = new List<Log>();
                string line;
                int index = 1;

                // 逐行读取而不是一次性读取全部内容
                while ((line = await sr.ReadLineAsync()) != null)
                {
                    if (!line.StartsWith(_currentYearMonth)) continue;

                    var items = line.Split(" -- ", 3, StringSplitOptions.None); // 限制分割次数为3
                    if (items.Length < 3) continue;

                    _currentLogLines += line + "\r\n";
                    logs.Add(new Log
                    {
                        Index = index++,
                        Time = DateTime.Parse(items[0]).ToString("HH:mm:ss.ffff"),
                        Level = items[1][1..^1],
                        Content = items[2].Trim(' ')
                    });
                }

                // 批量添加日志记录
                _logList.AddRange(logs);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void btn_openDir_Click(object sender, EventArgs e)
        {
            string logPath = Path.Combine(_logDir, _currentYearMonth, _currentDay);

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = logPath,
                UseShellExecute = true
            };

            Process process = new Process
            {
                StartInfo = startInfo
            };

            process.Start();
        }

        private void btn_exportTxt_Click(object sender, EventArgs e)
        {
            if (_currentLevel == null)
            {
                Generic.ShowMessage(this.ParentForm, "请选择日志级别", TType.Warn);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "文本文件|*.txt";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        sw.Write(_currentLogLines);
                    }

                    Generic.ShowMessage(this.ParentForm, "日志导出为 Txt 成功", TType.Success);

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
                    Generic.AppendLog($"日志导出为 Txt 失败：{ex.Message}", Constants.LogLevelEnum.Error, true);
                }

            }
        }

        private async void btn_exportExcel_Click(object sender, EventArgs e)
        {
            if (_currentLevel == null)
            {
                Generic.ShowMessage(this.ParentForm, "请选择日志级别", TType.Warn);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel文件|*.xlsx";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await MiniExcel.SaveAsAsync(saveFileDialog.FileName, _logList);

                    Generic.ShowMessage(this.ParentForm, "日志导出为 Excel 成功", TType.Success);

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
                    Generic.AppendLog($"日志导出为 Excel 失败：{ex.Message}", Constants.LogLevelEnum.Error, true);
                }

            }
        }



        public void Dispose()
        {
            // Dispose 在切换导航时，会被调用，但内存还是没降。只有在重新进入日志管理视图时，内存才会降
            _currentLogLines = string.Empty;
            _logList?.Clear();

            cmb_yearMonth.SelectedValueChanged -= cmb_yearMonth_SelectedIndexChanged;
            cmb_day.SelectedValueChanged -= cmb_day_SelectedIndexChanged;
            cmb_level.SelectedValueChanged -= cmb_level_SelectedIndexChanged;

            btn_openDir.Click -= btn_openDir_Click;
            btn_exportTxt.Click -= btn_exportTxt_Click;
            btn_exportExcel.Click -= btn_exportExcel_Click;

            base.Dispose();
        }
    }
}
