using Newtonsoft.Json;

namespace ForSerialization
{
    public class SerializeAndDeserialize
    {
        public static void Write<T>(T types, string filename)
        {
            string json = JsonConvert.SerializeObject(types);
            File.WriteAllText(filename, json);
        }

        public static T Read<T>(string filename)
        {
            string json = File.ReadAllText(filename);
            T types = JsonConvert.DeserializeObject<T>(json);
            return types;
        }
    }
}
