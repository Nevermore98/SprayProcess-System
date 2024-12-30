using Microsoft.Extensions.DependencyInjection;
using System.Drawing.Text;

using IoTClient.Clients.PLC;
using IoTClient.Enums;
using SprayProcessSystem.Model;


namespace SprayProcessSystem.UI
{
    public class Global
    {
        public static Dictionary<string, ServiceLifetime> ViewToLifetimeDict { get; set; } = new();

        public static PrivateFontCollection FontCollection { get; set; } = new PrivateFontCollection();

        //public static AppConfig AppConfig { get; set; } = new();
        public static SiemensClient SiemensClient { get; set; }

        public static Dictionary<string, DataTypeEnum> PlcBatchReadDict = new();

        public static Dictionary<string, PlcData> PlcNameDataDict = new();
        //public static List<PlcData> PlcDataList { get; set; }  = new();



        // 获取所有控件
        public static List<Control> GetAllControls(Control control)
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

    }
}
