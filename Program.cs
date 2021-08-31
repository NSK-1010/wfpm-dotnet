using System;
using System.Net;
using System.CommandLine;

namespace wfpm_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("開発開始すぐすぎるのでとりましっぽりをダウンロードするだけ");
            WebClient wb = new WebClient();
            wb.DownloadFile("https://fontdasu.com/download/shippori3.zip","/tmp/shippori3.zip");
        }
    }
}