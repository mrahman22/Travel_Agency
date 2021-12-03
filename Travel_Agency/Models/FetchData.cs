using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Travel_Agency
{
    public class FetchData : IFetchData
    {
        private string mainPath = "/Users/mustaburrahman/RiderProjects/Travel_Agency/Travel_Agency/Data/";
        
        public List<T> GetData<T>(DataType dataType)
        {
            var dataPath = File.ReadAllText($@"{mainPath}{dataType}.json");
            return JsonConvert.DeserializeObject<List<T>>(dataPath);
        }
    }
}