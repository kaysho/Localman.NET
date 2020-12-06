using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Localman.NET
{
    public class JsonReader
    {
        public static List<StateDetails> GetStateDetails()
        {

            List<StateDetails> stateDetails = new List<StateDetails>();
            string jsonFileName = "state_details.json";
            var assembly = typeof(JsonReader).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
            using (var reader = new StreamReader(stream))
            {

                var jsonString = reader.ReadToEnd();

                stateDetails = JsonConvert.DeserializeObject<List<StateDetails>>(jsonString);
            }


            return stateDetails;
        }
    }
}
