using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            // service without proxy
            Console.WriteLine("Service without proxy");
            YouTubeService youTubeService = new YouTubeService();

            youTubeService.GetVideo(10);
            youTubeService.GetVideo(10);

            // service with proxy
            Console.WriteLine("Service with proxy");

            ProxyYouTubeService proxyYouTubeService = new ProxyYouTubeService(youTubeService);

            proxyYouTubeService.GetVideo(20);
            proxyYouTubeService.GetVideo(20);
            Console.ReadLine();
        }
    }
}
