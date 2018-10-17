using System;
using System.Net;

namespace WebCrawler
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new WebClient();
            var text = client.DownloadString("https://www.facebook.com/");
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
