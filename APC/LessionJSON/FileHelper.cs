using System.IO;
using Newtonsoft.Json;

namespace LessionJSON
{
    class FileHelper
    {
        public static T ReadFile<T>(string fullpath){
            string responseData = string.Empty;
            using(StreamReader sr = File.OpenText(fullpath)){
                responseData = sr.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<T>(responseData);
        }

        public static void WriteFile<T>(string fullpath, object model){
            using(StreamWriter sw = File.CreateText(Path.Combine(fullpath))){
                var jsonData = JsonConvert.SerializeObject(model);
                sw.Write(jsonData);
            }
        }
    }
}