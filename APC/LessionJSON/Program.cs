using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LessionJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = @"C:\CodeGym\Class\C0621H2\APC\LessionJSON\data";
            string file = "matrix.json";
            string data = "";
            using(StreamReader sr = File.OpenText(Path.Combine(path, file)) ){
                data = sr.ReadToEnd();
            }

            var result = JsonConvert.DeserializeObject<Data>(data);
            var total = 0;

            for(int i=0; i< result.matrix.Count;i++){
                for(int j = 0; j< result.matrix[i].Count; j++){
                    result.matrix[i][j]*=2;
                    total += result.matrix[i][j];
                }
            }

            var response = new Response(){
                matrix = result.matrix,
                total = total
            };

            using(StreamWriter sw = File.CreateText(Path.Combine(path, "result.json"))){
                var jsonData = JsonConvert.SerializeObject(response);
                sw.Write(jsonData);
            }
        }
    }

    class Data{
        public List<List<int>> matrix  { get; set; }
    }

    class Response
    {
        public List<List<int>> matrix  { get; set; }
        public int total { get; set; }
    }
}
