using System;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    // sync

    /*static void Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage response_1 = client.GetAsync("https://meowfacts.herokuapp.com").Result;
                HttpResponseMessage response_2 = client.GetAsync("https://official-joke-api.appspot.com/random_joke").Result;
                HttpResponseMessage response_3 = client.GetAsync("https://yesno.wtf/api").Result;
               
                response_1.EnsureSuccessStatusCode();
                response_2.EnsureSuccessStatusCode();
                response_3.EnsureSuccessStatusCode();

                string jsonString_1 = response_1.Content.ReadAsStringAsync().Result;
                string jsonString_2 = response_2.Content.ReadAsStringAsync().Result;
                string jsonString_3 = response_3.Content.ReadAsStringAsync().Result;

                dynamic json_1 = JsonConvert.DeserializeObject(jsonString_1);
                dynamic json_2 = JsonConvert.DeserializeObject(jsonString_2);
                dynamic json_3 = JsonConvert.DeserializeObject(jsonString_3);

                string value_1 = json_1["this"];
                string value_11 = json_1["that"];
                string value_2 = json_2["setup"];
                string value_3 = json_3["answer"];

                Console.WriteLine("g: " + value_1);
                Console.WriteLine("g: " + value_11);
                Console.WriteLine("Шутка: " + value_2);
                value_2 = json_2["punchline"];
                Console.WriteLine("\t" + value_2);
                Console.WriteLine("Просто скажите да или нет!: " + value_3);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
    }*/

    // async

    static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage response_1 = await client.GetAsync("http://api.open-notify.org/iss-now.json");
                HttpResponseMessage response_2 = await client.GetAsync("https://official-joke-api.appspot.com/random_joke");
                HttpResponseMessage response_3 = await client.GetAsync("https://yesno.wtf/api");
                
                response_1.EnsureSuccessStatusCode();
                response_2.EnsureSuccessStatusCode();
                response_3.EnsureSuccessStatusCode();

                string jsonString_1 = await response_1.Content.ReadAsStringAsync();
                string jsonString_2 = await response_2.Content.ReadAsStringAsync();
                string jsonString_3 = await response_3.Content.ReadAsStringAsync();

                dynamic json_1 = JsonConvert.DeserializeObject(jsonString_1);
                dynamic json_2 = JsonConvert.DeserializeObject(jsonString_2);
                dynamic json_3 = JsonConvert.DeserializeObject(jsonString_3);

                string value_1 = json_1["this"];
                string value_11 = json_1["that"];
                string value_2 = json_2["setup"];
                string value_3 = json_3["answer"];

                Console.WriteLine("g: " + value_1);
                Console.WriteLine("g: " + value_11);
                Console.WriteLine("Шутка: " + value_2);
                value_2 = json_2["punchline"];
                Console.WriteLine("\t" + value_2);
                Console.WriteLine("Просто скажите да или нет!: " + value_3);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
    }
}