using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProgressTaskFour
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var client = new WebClient();

            client.DownloadStringCompleted += (sender, e) =>
            {
                Console.WriteLine(e.Result);
            };

            string url = "https://restcountries.eu/rest/v2/all";
            client.DownloadStringAsync(new Uri(url));

            Console.ReadLine();
        }
    }
}
