namespace SprayProcessSystem.BLL.Dto.DataDto
{
    public class DataQueryResultDto: BaseDto
    {
        public string DegreasingPH { get; set; }
        public string PhosphatingPH { get; set; }

        public string DegreasingSprayPumpPressure { get; set; }
        public string RoughWashSprayPumpPressure { get; set; }
        public string PhosphatingSprayPumpPressure { get; set; }
        public string FineWashSprayPumpPressure { get; set; }

        public string WaterStoveTemperature { get; set; }
        public string SolidifyStoveTemperature { get; set; }

        public string FactoryTemperature { get; set; }
        public string FactoryHumidity { get; set; }
    }
}
