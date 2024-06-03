using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Modul15.LoginRegist;


namespace Modul15.JSONConfiguration
{
    public class JSONConfig
    {
        public Sign sign = new Sign();



        public JSONConfig config;
        public string filePath = "D:\\KPL_W15_1302220093\\KPL-PRAK-W15\\bin\\Debug\\net8.0\\Account.json";

        public JSONConfig()
        {
            /*try
            {
                readConfig();
            } catch {
                setDefault()
            }*/
    }

        

        public void NewAccount(string username, string password) {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            config = new JSONConfig();  
            String jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
