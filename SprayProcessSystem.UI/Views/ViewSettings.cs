using AntdUI;
using IoTClient.Common.Enums;
using SprayProcessSystem.Model;
using System.Text.Encodings.Web;
using System.Text.Json;
using FolderBrowserDialog = AntdUI.FolderBrowserDialog;

namespace SprayProcessSystem.UI.Views
{
    public partial class ViewSettings : UserControl
    {
        public ViewSettings()
        {
            InitializeComponent();

            Load += ViewSettings_Load;
            BindEvents();
        }

        private void LoadAppConfig()
        {
            txt_plcConfigPath.Text = AppConfig.Current.Plc.ConfigPath;
            txt_plcIp.Text = AppConfig.Current.Plc.Ip;
            txt_plcPort.Text = AppConfig.Current.Plc.Port.ToString();
            cmb_plcType.SelectedValue = AppConfig.Current.Plc.SiemensVersion.ToString();
            txt_plcRack.Text = AppConfig.Current.Plc.Rack.ToString();
            txt_plcSlot.Text = AppConfig.Current.Plc.Slot.ToString();
            txt_plcConnectTimeout.Text = AppConfig.Current.Plc.ConnectTimeout.ToString();
            txt_plcReadInterval.Text = AppConfig.Current.Plc.ReadInterval.ToString();
            txt_plcReConnectInterval.Text = AppConfig.Current.Plc.ReConnectInterval.ToString();

            txt_logDir.Text = AppConfig.Current.Log.Dir;

            int keepDays = AppConfig.Current.Log.KeepDays;
            cmb_logKeepDays.SelectedValue = keepDays switch
            {
                -1 => "不清理",
                3 => "3天",
                7 => "7天",
                15 => "15天",
                30 => "30天",
                60 => "60天",
                _ => cmb_logKeepDays.SelectedValue
            };
        }

        private void ViewSettings_Load(object? sender, EventArgs e)
        {
            InitControls();
            LoadAppConfig();
        }

        private void InitControls()
        {
            upd_plcExcel.Filter = "Excel 文件|*.xls;*.xlsx";
            cmb_plcType.Items.AddRange(Enum.GetNames(typeof(SiemensVersion)));
        }

        private void BindEvents()
        {
            btn_logDir.Click += (s, e) =>
            {
                var dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string logDirPath = Path.Combine(dialog.DirectoryPath, "Logs");
                    txt_logDir.Text = logDirPath;
                    AppConfig.Current.Log.Dir = logDirPath;
                    AppConfig.Current.Save();


                    string configFilePath = Path.Combine(Environment.CurrentDirectory, "Configs", "appsettings.json");
                    var options = new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
                    var json = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(File.ReadAllText(configFilePath));

                    if (json.TryGetValue("NLog", out var nlogElement))
                    {
                        var nlog = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(nlogElement.GetRawText());
                        if (nlog.TryGetValue("targets", out var targetsElement))
                        {
                            var targets = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(targetsElement.GetRawText());
                            var modifiedTargets = new Dictionary<string, object>();

                            foreach (var (key, target) in targets)
                            {
                                var targetConfig = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(target.GetRawText());
                                if (targetConfig.ContainsKey("fileName"))
                                {
                                    var fileName = targetConfig["fileName"].GetString();
                                    var dateIndex = fileName.IndexOf("/${date:format=yyyy-MM}");
                                    if (dateIndex >= 0)
                                    {
                                        targetConfig["fileName"] = JsonSerializer.SerializeToElement(
                                            dialog.DirectoryPath.Replace('\\', '/') + "/Logs" + fileName.Substring(dateIndex));
                                    }
                                }
                                modifiedTargets[key] = targetConfig;
                            }

                            nlog["targets"] = JsonSerializer.SerializeToElement(modifiedTargets);
                            json["NLog"] = JsonSerializer.SerializeToElement(nlog);
                            File.WriteAllText(configFilePath, JsonSerializer.Serialize(json, options));

                            if (Generic.ShowModal(ParentForm, "需要重启应用", "日志目录已修改，需重启应用生效。\n是否立即重启应用？", TType.Warn) == DialogResult.OK)
                            {
                                Application.Restart();
                            }
                        }
                    }

                }
            };


            var allControls = Generic.GetDescendantControls(this);
            foreach (var item in allControls)
            {
                if (item is Input input)
                {
                    input.LostFocus += (s, e) =>
                    {
                        string propFullName = input.Name.Replace("txt_", "");
                        if (propFullName.StartsWith("plc"))
                        {
                            var propName = propFullName.Replace("plc", "");
                            switch (propName)
                            {
                                case "ConfigPath":
                                    if (AppConfig.Current.Plc.ConfigPath == input.Text) return;
                                    AppConfig.Current.Plc.ConfigPath = input.Text;
                                    break;
                                case "Ip":
                                    if (AppConfig.Current.Plc.Ip == input.Text) return;
                                    AppConfig.Current.Plc.Ip = input.Text;
                                    break;
                                case "Port":
                                    if (AppConfig.Current.Plc.Port == int.Parse(input.Text)) return;
                                    AppConfig.Current.Plc.Port = int.Parse(input.Text);
                                    break;
                                case "Slot":
                                    if (AppConfig.Current.Plc.Slot == byte.Parse(input.Text)) return;
                                    AppConfig.Current.Plc.Slot = byte.Parse(input.Text);
                                    break;
                                case "Rack":
                                    if (AppConfig.Current.Plc.Rack == byte.Parse(input.Text)) return;
                                    AppConfig.Current.Plc.Rack = byte.Parse(input.Text);
                                    break;
                                case "ConnectTimeout":
                                    if (AppConfig.Current.Plc.ConnectTimeout == int.Parse(input.Text)) return;
                                    AppConfig.Current.Plc.ConnectTimeout = int.Parse(input.Text);
                                    break;
                                case "ReadInterval":
                                    if (AppConfig.Current.Plc.ReadInterval == int.Parse(input.Text)) return;
                                    AppConfig.Current.Plc.ReadInterval = int.Parse(input.Text);
                                    break;
                                case "ReConnectInterval":
                                    if (AppConfig.Current.Plc.ReConnectInterval == int.Parse(input.Text)) return;
                                    AppConfig.Current.Plc.ReConnectInterval = int.Parse(input.Text);
                                    break;
                            }
                            AppConfig.Current.Save();
                        }

                        if (propFullName.StartsWith("log"))
                        {
                            var propName = propFullName.Replace("log", "");
                            switch (propName)
                            {
                                case "Dir":
                                    if (AppConfig.Current.Log.Dir == input.Text) return;
                                    AppConfig.Current.Log.Dir = input.Text;
                                    break;
                                case "KeepDays":
                                    if (AppConfig.Current.Log.KeepDays == int.Parse(input.Text)) return;
                                    AppConfig.Current.Log.KeepDays = int.Parse(input.Text);
                                    break;
                            }
                            AppConfig.Current.Save();
                        }
                    };
                }

                if (item is Select select)
                {
                    select.SelectedValueChanged += (s, e) =>
                    {
                        string propFullName = select.Name.Replace("cmb_", "");
                        if (propFullName.StartsWith("plc"))
                        {
                            var propName = propFullName.Replace("plc", "");
                            switch (propName)
                            {
                                case "Type":
                                    if (AppConfig.Current.Plc.SiemensVersion.ToString() == select.SelectedValue.ToString()) return;
                                    AppConfig.Current.Plc.SiemensVersion = (SiemensVersion)Enum.Parse(typeof(SiemensVersion), select.SelectedValue.ToString());
                                    break;
                            }
                            AppConfig.Current.Save();
                        }

                        if (propFullName.StartsWith("log"))
                        {
                            var propName = propFullName.Replace("log", "");
                            switch (propName)
                            {
                                case "KeepDays":
                                    var keepDays = AppConfig.Current.Log.KeepDays;

                                    string selectedValue = (string)e.Value;
                                    AppConfig.Current.Log.KeepDays = selectedValue switch
                                    {
                                        "不清理" => -1,
                                        "3天" => 3,
                                        "7天" => 7,
                                        "15天" => 15,
                                        "30天" => 30,
                                        "60天" => 60,
                                        _ => AppConfig.Current.Log.KeepDays
                                    };
                                    if (keepDays == AppConfig.Current.Log.KeepDays) return;
                                    break;
                            }
                            AppConfig.Current.Save();
                        }
                    };
                }
            }
        }


        private void upd_plcConfigPath_DragChanged(object sender, AntdUI.StringsEventArgs e)
        {
            string[] filePaths = e.Value;
            txt_plcConfigPath.Text = filePaths[0];
            AppConfig.Current.Plc.ConfigPath = filePaths[0];
            AppConfig.Current.Save();
        }
    }
}
