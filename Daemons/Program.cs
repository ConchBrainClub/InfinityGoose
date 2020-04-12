using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Daemons
{
    class Program
    {
        static void Main(string[] args)
        {
            //此文件放入桌面鹅根目录文件夹
            //和GooseDesktop.exe放在一起并压缩
            string path = Directory.GetCurrentDirectory();
            while (true)
            {
                if (Process.GetProcessesByName("GooseDesktop").Length == 0)
                {
                    Process.Start(path + "\\GooseDesktop.exe");
                }
                Thread.Sleep(5000);
            }
        }
    }
}
