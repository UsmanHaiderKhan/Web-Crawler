using System;
using System.Net;

namespace WebCrawler
{
    public class Program
    {
        static void Main(string[] args)
        {
            //it is web client 
            var client = new WebClient();
            // getting web url to Crawle
            var text = client.DownloadString("http://lkeshop.somee.com/");
            // showing the Crawling data
            Console.WriteLine(text);
            //it pasuse the screen
            Console.ReadKey();
            //
        }
    }
}
