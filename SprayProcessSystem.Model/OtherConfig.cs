namespace SprayProcessSystem.Model
{
    [ConfigFile("Configs/OtherConfig.json")]
    public class OtherConfig:JsonConfig<OtherConfig>
    {
        public string OtherConfigTest { get; set; }

        public override void SetDefault()
        {
            OtherConfigTest = "OtherConfigTest";
        }
    }
}
