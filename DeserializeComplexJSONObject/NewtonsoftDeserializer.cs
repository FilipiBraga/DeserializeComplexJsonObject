using DeserializeComplexJSONObject.POCO;
using Newtonsoft.Json;

namespace DeserializeComplexJSONObject
{
    public class NewtonsoftDeserializer
    {
        public Company? DeserializeUsingGenericNewtonSoftJson(string json)
        {
            var company = JsonConvert.DeserializeObject<Company>(json);

            return company;
        }

        public Company? DeserializeUsingGenericNewtonSoftJson2(string json)
        {
            var company = JsonConvert.DeserializeObject<Company>(json);

            return company;
        }
    }
}
