/*using System;
using System.Net.Http;
using System.Threading.Tasks;
namespace GET_HOSTING_DATA
{
    class Program
    {
        static async Task Main()
        {
         
            string apiUrl = "http://192.168.0.252/api/Values/Get"; 
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(content);
                    }
                    else
                    {
                        Console.WriteLine($"HTTP Error: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
      */


using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Specify the API URL
        string apiUrl = "http://192.168.0.252/api/Values/PostValue";

        // Create an instance of HttpClient
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Prepare the data to be sent as key-value pairs
                var data = new
                {
                    staff_name = "varun",
                    staff_age = "21"
                };

                // Serialize the data to JSON
                var jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                // Create the HTTP content with JSON data
                var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");

                // Send the POST request
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                // Check if the request was successful (status code 200)
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Data successfully posted.");
                    Console.WriteLine("Response: " + responseContent);
                }
                else
                {
                    Console.WriteLine("Failed to post data. Status Code: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
