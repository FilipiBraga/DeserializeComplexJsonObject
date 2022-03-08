using DeserializeComplexJSONObject.POCO;
using System.Text.Json;

namespace DeserializeComplexJSONObject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var json = ReadJsonFile();
            var systemTextJson = JsonSerializer.Deserialize<Company>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        private static string ReadJsonFile()
        {
            using StreamReader reader = new (@$"{AppContext.BaseDirectory}\ComplexObject.json");
            return reader.ReadToEnd();
        }
    }
}