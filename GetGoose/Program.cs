using IWshRuntimeLibrary;
using System;
using System.IO;
using System.IO.Compression;
using System.Net.Http;

namespace GetGoose
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = @"C:\ProgramData\Goose";
            string fullName = path + "\\Goose.zip";

            string startupDir = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!Directory.Exists(startupDir))
            {
                Directory.CreateDirectory(startupDir);
            }

            HttpClient httpClient = new HttpClient();
            Console.WriteLine("开始下载......");
            byte[] buffer = httpClient.GetAsync("压缩文件（DG.zip）下载地址").Result.Content.ReadAsByteArrayAsync().Result;
            System.IO.File.WriteAllBytes(fullName, buffer);
            Console.WriteLine("下载完成！");

            Console.WriteLine("解压中....");
            ZipFile.ExtractToDirectory(fullName, path);
            Console.WriteLine("解压完成！");

            System.IO.File.Delete(fullName);

            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(startupDir + "//flash.lnk");
            shortcut.WorkingDirectory = path;
            shortcut.TargetPath = path+ "\\Daemons.exe";
            shortcut.Save();

            Console.WriteLine("配置完成");

            Console.WriteLine("完成！按任意键退出");
            Console.Read();
        }
    }
}
