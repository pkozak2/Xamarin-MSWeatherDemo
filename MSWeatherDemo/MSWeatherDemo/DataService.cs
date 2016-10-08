﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MSWeatherDemo
{
    class DataService
    {
        public static async Task<dynamic> getDataFormService(string queryAddress)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryAddress);

            dynamic data = null;
            if (response != null)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);
            }
            return data;
        }
    }
}
