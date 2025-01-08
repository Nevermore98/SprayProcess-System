using SqlSugar;

namespace SprayProcessSystem.Model.Entities
{
    [SugarTable("recipe")]
    public class RecipeEntity : BaseEntity
    {
        [SugarColumn(ColumnDataType = "Nvarchar(255)", ColumnDescription = "产品类型", IsNullable = false)]
        public string? ProductType { get; set; }

        [SugarColumn(ColumnDescription = "脱脂设定压力上限值")]
        public string? DegreasingPressureUpperLimit { get; set; }

        [SugarColumn(ColumnDescription = "脱脂设定压力下限值")]
        public string? DegreasingPressureLowerLimit { get; set; }

        [SugarColumn(ColumnDescription = "粗洗喷淋泵过载上限值")]
        public string? RoughWashPumpOverloadUpperLimit { get; set; }

        [SugarColumn(ColumnDescription = "粗洗液位下限值")]
        public string? RoughWashLiquidLevelLowerLimit { get; set; }

        [SugarColumn(ColumnDescription = "陶化喷淋泵过载上限值")]
        public string? PhosphatingPumpOverloadUpperLimit { get; set; }

        [SugarColumn(ColumnDescription = "精洗喷淋泵过载上限值")]
        public string? FineWashPumpOverloadUpperLimit { get; set; }

        [SugarColumn(ColumnDescription = "精洗液位下限值")]
        public string? FineWashLiquidLevelLowerLimit { get; set; }

        [SugarColumn(ColumnDescription = "水分炉温度上限值")]
        public string? WaterStoveTemperatureUpperLimit { get; set; }

        [SugarColumn(ColumnDescription = "水分炉温度下限值")]
        public string? WaterStoveTemperatureLowerLimit { get; set; }

        [SugarColumn(ColumnDescription = "冷却室离心风机过载上限值")]
        public string? CoolingRoomFanOverloadUpperLimit { get; set; }

        [SugarColumn(ColumnDescription = "固化炉温度上限值")]
        public string? SolidifyStoveTemperatureUpperLimit { get; set; }

        [SugarColumn(ColumnDescription = "固化炉温度下限值")]
        public string? SolidifyStoveTemperatureLowerLimit { get; set; }

        [SugarColumn(ColumnDescription = "输送机设定速度")]
        public string? ConveyorSetSpeed { get; set; }

        [SugarColumn(ColumnDescription = "输送机设定频率")]
        public string? ConveyorSetFrequency { get; set; }
    }
}
