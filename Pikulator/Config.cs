using Newtonsoft.Json;

namespace Pikulator
{
    public class Config
    {
        public static string path = Path.Combine(Program.path + "/Config.json");
        public static Config Read()
        {
            return JsonConvert.DeserializeObject<Config>(File.ReadAllText(path));
        }
        public void Write()
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(this, Formatting.Indented));
        }
    }
}
