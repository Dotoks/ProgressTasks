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
            //Pretty sure in order to compelete this task you'll need to use WebServiceDataSource which is available only through Telerik Reporting, which i have to pay for.
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
