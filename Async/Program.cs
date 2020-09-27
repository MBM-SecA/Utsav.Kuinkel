using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static async Task Main()
        {

            Console.WriteLine("Hello World!");

            HttpClient client = new HttpClient();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var google = client.GetStringAsync("https://google.com/").Result;
            var yahoo = client.GetStringAsync("https://yahoo.com/").Result;
            var facebook = client.GetStringAsync("https://facebook.com/").Result;
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();
            var googleA = await client.GetStringAsync("https://google.com/");
            var yahooA = await client.GetStringAsync("https://yahoo.com/");
            var facebookA = await client.GetStringAsync("https://facebook.com/");
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");


        }
    }
}
