using System;
using System.Net.Http;
using System.Threading.Tasks;
namespace HttpClientExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var url = "https://www.example.com/api/data/1"; // Specify the URL
                    var response = await client.GetAsync(url); // Send the GET request.
                    if (response.IsSuccessStatusCode) // Check the status
                    {
                        var content = await response.Content.ReadAsStringAsync(); // Read the response
                        Console.WriteLine(content);
                    }
                    else
                    {
                        Console.WriteLine("Error: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
