using MiniExcelLibs.Attributes;
using SqlSugar;

namespace SprayProcessSystem.Model.Entities
{
    [SugarTable("data")]
    public class DataEntity : BaseEntity
    {
        [SugarColumn(ColumnDescription = "脱脂pH值", IsNullable = true)]
        [ExcelColumn(Name = "脱脂pH值", Width = 18)]
        public string? DegreasingPH { get; set; }

        [SugarColumn(ColumnDescription = "陶化pH值", IsNullable = true)]
        [ExcelColumn(Name = "陶化pH值", Width = 18)]
        public string? PhosphatingPH { get; set; }

        [SugarColumn(ColumnDescription = "脱脂喷淋泵压力值", IsNullable = true)]
        [ExcelColumn(Name = "脱脂喷淋泵压力值", Width = 18)]
        public string? DegreasingSprayPumpPressure { get; set; }

        [SugarColumn(ColumnDescription = "粗洗喷淋泵压力值", IsNullable = true)]
        [ExcelColumn(Name = "粗洗喷淋泵压力值", Width = 18)]
        public string? RoughWashSprayPumpPressure { get; set; }

        [SugarColumn(ColumnDescription = "陶化喷淋泵压力值", IsNullable = true)]
        [ExcelColumn(Name = "陶化喷淋泵压力值", Width = 18)]
        public string? PhosphatingSprayPumpPressure { get; set; }

        [SugarColumn(ColumnDescription = "精洗喷淋泵压力值", IsNullable = true)]
        [ExcelColumn(Name = "精洗喷淋泵压力值", Width = 18)]
        public string? FineWashSprayPumpPressure { get; set; }

        [SugarColumn(ColumnDescription = "水分炉测量温度", IsNullable = true)]
        [ExcelColumn(Name = "水分炉测量温度", Width = 18)]
        public string? WaterStoveTemperature { get; set; }

        [SugarColumn(ColumnDescription = "固化炉测量温度", IsNullable = true)]
        [ExcelColumn(Name = "固化炉测量温度", Width = 18)]
        public string? SolidifyStoveTemperature { get; set; }

        [SugarColumn(ColumnDescription = "厂内温度", IsNullable = true)]
        [ExcelColumn(Name = "厂内温度", Width = 18)]
        public string? FactoryTemperature { get; set; }

        [SugarColumn(ColumnDescription = "厂内湿度", IsNullable = true)]
        [ExcelColumn(Name = "厂内湿度", Width = 18)]
        public string? FactoryHumidity { get; set; }

        // 覆盖基类属性，data 数据在 excel 就忽略更新时间
        [ExcelIgnore]
        public new DateTime UpdatedAt { get; set; }
    }
}
