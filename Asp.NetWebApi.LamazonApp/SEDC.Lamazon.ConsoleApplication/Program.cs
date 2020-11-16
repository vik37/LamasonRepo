using System;
using System.Net.Http;

namespace SEDC.Lamazon.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Performance check started...");
            Console.WriteLine("-------------------------------");

            CheckOrderPerformance();
            Console.ReadLine();
        }
        static void CheckOrderPerformance()
        {
            HttpClient client = new HttpClient();
            string apiUrl = "http://localhost:54327/api/External/performance/getorder";

            int limit = 1000;

            HttpResponseMessage response = client.GetAsync(apiUrl).Result;
            string responseBody = response.Content.ReadAsStringAsync().Result;

            if(int.Parse(responseBody) > limit)
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"Performance: {responseBody}ms [Limit: {limit}ms]");
        }
    }
}
