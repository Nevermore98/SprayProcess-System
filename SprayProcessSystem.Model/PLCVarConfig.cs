using MiniExcelLibs.Attributes;


namespace SprayProcessSystem.Model
{
    public class PlcVarConfig
    {
        [ExcelColumnName("所属模块")]
        public string Module { get; set; }
        [ExcelColumnName("名称")]
        public string Name { get; set; }
        [ExcelColumnName("PLC地址")]
        public string Address { get; set; }
        [ExcelColumnName("变量类型")]
        public string VarType { get; set; }
        [ExcelColumnName("是否保存")]
        public bool IsSaved { get; set; }
    }
}
