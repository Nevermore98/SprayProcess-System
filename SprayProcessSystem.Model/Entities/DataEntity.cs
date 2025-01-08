using SqlSugar;

namespace SprayProcessSystem.Model.Entities
{
    [SugarTable("data")]
    public class DataEntity : BaseEntity
    {
        [SugarColumn(ColumnDescription = "插入时间")]
        public DateTime InsertTime { get; set; }

        [SugarColumn(ColumnDescription = "脱脂pH值")]
        public string? DegreasingPH { get; set; }

        [SugarColumn(ColumnDescription = "陶化pH值")]
        public string? PhosphatingPH { get; set; }

        [SugarColumn(ColumnDescription = "脱脂喷淋泵压力值")]
        public string? DegreasingSprayPumpPressure { get; set; }

        [SugarColumn(ColumnDescription = "粗洗喷淋泵压力值")]
        public string? RoughWashSprayPumpPressure { get; set; }

        [SugarColumn(ColumnDescription = "陶化喷淋泵压力值")]
        public string? PhosphatingSprayPumpPressure { get; set; }

        [SugarColumn(ColumnDescription = "精洗喷淋泵压力值")]
        public string? FineWashSprayPumpPressure { get; set; }

        [SugarColumn(ColumnDescription = "水分炉测量温度")]
        public string? WaterStoveTemperature { get; set; }

        [SugarColumn(ColumnDescription = "固化炉测量温度")]
        public string? SolidifyStoveTemperature { get; set; }

        [SugarColumn(ColumnDescription = "厂内温度")]
        public string? FactoryTemperature { get; set; }

        [SugarColumn(ColumnDescription = "厂内湿度")]
        public string? FactoryHumidity { get; set; }
    }
}
