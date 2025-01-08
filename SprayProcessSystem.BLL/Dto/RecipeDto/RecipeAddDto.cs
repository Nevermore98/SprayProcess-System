

namespace SprayProcessSystem.BLL.Dto.RecipeDto
{
    public class RecipeAddDto : BaseDto
    {
        public string? ProductType { get; set; }

        public string? DegreasingPressureUpperLimit { get; set; }
        public string? DegreasingPressureLowerLimit { get; set; }

        public string? RoughWashPumpOverloadUpperLimit { get; set; }
        public string? RoughWashLiquidLevelLowerLimit { get; set; }

        public string? PhosphatingPumpOverloadUpperLimit { get; set; }

        public string? FineWashPumpOverloadUpperLimit { get; set; }
        public string? FineWashLiquidLevelLowerLimit { get; set; }

        public string? WaterStoveTemperatureUpperLimit { get; set; }
        public string? WaterStoveTemperatureLowerLimit { get; set; }

        public string? CoolingRoomFanOverloadUpperLimit { get; set; }

        public string? SolidifyStoveTemperatureUpperLimit { get; set; }
        public string? SolidifyStoveTemperatureLowerLimit { get; set; }

        public string? ConveyorSetSpeed { get; set; }

        public string? ConveyorSetFrequency { get; set; }
    }
}
