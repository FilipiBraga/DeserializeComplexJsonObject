using DeserializeComplexJSONObject.POCO;
using System.Text.Json;

namespace DeserializeComplexJSONObject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------- Deserializing complex JSON object");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("---------- Reading JSON file");
            var json = ReadJsonFile();

            Console.WriteLine();

            Console.WriteLine("---------- Deserialize using System.Text.Json");
            var companyUsingSystemTextJson = DeserializeUsingGenericSystemTextJson(json);

            Console.WriteLine();

            Console.WriteLine("---------- Deserialize using Newtonsoft.Json");
            var companyUsingNewtonSoftJson = DeserializeUsingNewtonSoftJson(json);

            Console.WriteLine("End of execution");
        }

        private static Company? DeserializeUsingNewtonSoftJson(string json)
        {
            var company = Newtonsoft.Json.JsonConvert.DeserializeObject<Company>(json);

            return company;
        }

        private static Company? DeserializeUsingGenericSystemTextJson(string json)
        {
            var company = JsonSerializer.Deserialize<Company>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            return company;
        }

        private static Company? DeserializeUsingSystemTextJson(string json)
        {
            var company = (Company?)JsonSerializer.Deserialize(json, typeof(Company), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            return company;
        }

        private static string ReadJsonFile()
        {
            using StreamReader reader = new(@$"{AppContext.BaseDirectory}\ComplexObject.json");
            return reader.ReadToEnd();
        }
    }
}