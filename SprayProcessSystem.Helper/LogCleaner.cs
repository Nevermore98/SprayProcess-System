using System.Diagnostics;

namespace SprayProcessSystem.Helper
{

    public static class LogCleaner
    {
        public static void CleanOldLogs(string logRootDir, int daysToKeep)
        {
            if (daysToKeep == -1) return;

            var cutoffDate = DateTime.Now.AddDays(-daysToKeep);

            // 遍历日志根目录下的所有月份文件夹
            foreach (var monthDir in Directory.GetDirectories(logRootDir))
            {
                // 遍历月份文件夹下的所有日期文件夹
                foreach (var dayDir in Directory.GetDirectories(monthDir))
                {
                    var dirInfo = new DirectoryInfo(dayDir);
                    if (dirInfo.CreationTime < cutoffDate)
                    {
                        try
                        {
                            Directory.Delete(dayDir, true);
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"删除 {dayDir} 文件夹失败：{ex.Message}");
                        }
                    }
                }

                // 如果月份文件夹为空，删除月份文件夹
                if (Directory.GetFiles(monthDir).Length == 0 && Directory.GetDirectories(monthDir).Length == 0)
                {
                    try
                    {
                        Directory.Delete(monthDir);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"删除 {monthDir} 文件夹失败：{ex.Message}");
                    }
                }
            }
        }
    }
}
