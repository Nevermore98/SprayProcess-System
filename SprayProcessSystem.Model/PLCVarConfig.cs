using MiniExcelLibs.Attributes;


namespace SprayProcessSystem.Model
{
    public class PlcVarConfig
    {
        [ExcelColumnName("����ģ��")]
        public string Module { get; set; }
        [ExcelColumnName("����")]
        public string Name { get; set; }
        [ExcelColumnName("PLC��ַ")]
        public string Address { get; set; }
        [ExcelColumnName("��������")]
        public string VarType { get; set; }
        [ExcelColumnName("�Ƿ񱣴�")]
        public bool IsSaved { get; set; }
    }
}
