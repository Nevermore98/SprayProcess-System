using AntdUI;
using NLog;
using SprayProcessSystem.Helper;
using static SprayProcessSystem.Model.Constants;

namespace SprayProcessSystem.UI
{
    public class Generic
    {
        private static ILogger _logger;

        /// <summary>
        /// 写入 PLC 数据
        /// </summary>
        /// <returns></returns>
        public static bool PlcWrite(string name, dynamic value)
        {
            var plcData = Global.PlcNameDataDict[name];
            return Global.SiemensClient.Write(plcData.Address, value).IsSucceed;
        }



        /// <summary>
        /// 获取所有后代控件
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static List<Control> GetDescendantControls(Control control)
        {
            List<Control> allControls = new List<Control>();
            CollectControls(control.Controls, allControls);
            return allControls;
        }

        private static void CollectControls(Control.ControlCollection controls, List<Control> allControls)
        {
            foreach (Control control in controls)
            {
                allControls.Add(control); // 将当前控件添加到列表中
                                          // 如果当前控件有子控件，则递归调用此方法
                if (control.HasChildren)
                {
                    CollectControls(control.Controls, allControls);
                }
            }
        }

        /// <summary>
        /// 获取控件的所有子控件
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static List<Control> GetChildControls(Control control)
        {
            List<Control> childControls = new List<Control>();
            foreach (Control item in control.Controls)
            {
                childControls.Add(item);
            }
            return childControls;
        }

        public static void AppendLog(string message, LogLevelEnum logLevelEnum, Input inputControl, bool isWriteToLog = true)
        {
            _logger = LogManager.GetCurrentClassLogger();

            inputControl.AppendText($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} --- [{EnumHelper.GetEnumDescription(logLevelEnum)}] --- {message}\r\n");

            if (!isWriteToLog) return;
            switch (logLevelEnum)
            {
                case LogLevelEnum.Info:
                    _logger.Info(message);
                    break;
                case LogLevelEnum.Warn:
                    _logger.Warn(message);
                    break;
                case LogLevelEnum.Error:
                    _logger.Error(message);
                    break;
                case LogLevelEnum.Debug:
                    _logger.Debug(message);
                    break;
                default:
                    _logger.Info(message);
                    break;
            }
        }


        public static void ShowMessage(Form form, string message, TType messageType)
        {
            AntdUI.Message.open(new AntdUI.Message.Config(form, message, messageType)
            {
                AutoClose = 3,
                Align = TAlignFrom.Top,
                Font = new Font(Global.FontCollection.Families[0], 13),
                ShowInWindow = true
            });
        }

        public static DialogResult ShowModal(Form form, string title, object content, TType modalType, bool isShowDefaultBtns =true)
        {
            return AntdUI.Modal.open(new AntdUI.Modal.Config(form, title, content, modalType)
            {
                Keyboard = false,
                Font = new Font(Global.FontCollection.Families[0], 11),
                BtnHeight = isShowDefaultBtns ? 38 : 0,
                MaskClosable = true,
            });
        }
    }
}
