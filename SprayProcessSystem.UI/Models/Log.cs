using AntdUI;
using MiniExcelLibs.Attributes;

namespace SprayProcessSystem.UI.Models
{
    public class Log
    {
        [ExcelColumn(Name = "序号")]
        public int Index { get; set; }
        [ExcelColumn(Name = "时间", Width = 14)]
        public string Time { get; set; }
        [ExcelColumn(Name = "级别")]
        public string Level { get; set; }
        [ExcelColumn(Name = "内容", Width = 90)]
        public string Content { get; set; }

        [ExcelIgnore]
        public CellTag LevelTag
        {
            get
            {
                if (Level == "信息")
                {
                    return new CellTag("信息", TTypeMini.Info);
                }
                else if (Level == "警告")
                {
                    return new CellTag("警告", TTypeMini.Warn);
                }
                else if (Level == "错误")
                {
                    return new CellTag("错误", TTypeMini.Error);
                }
                else
                {
                    return new CellTag("未知", TTypeMini.Default);
                }
            }
        }

    }
}
