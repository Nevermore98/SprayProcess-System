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

        public static SiemensClient SiemensClient { get; set; }

        public static Dictionary<string, DataTypeEnum> PlcBatchReadDict = new();

        public static Dictionary<string, PlcData> PlcNameDataDict = new();


    }
}
