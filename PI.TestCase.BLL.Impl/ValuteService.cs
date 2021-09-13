using Newtonsoft.Json.Linq;
using PI.TestCase.BLL.Interface;
using PI.TestCase.DAL.Interface;
using PI.TestCase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;

namespace PI.TestCase.BLL.Impl
{
    public class ValuteService : IValuteService
    {
        private readonly IValuteRepository _da;
        public ValuteService(IValuteRepository da)
        {
            _da = da;
            LoadData();
        }

        public void LoadData()
        {
            String url = "https://www.cbr-xml-daily.ru/daily_json.js";

            using (WebClient client = new WebClient())
            {
                String jsonStr = client.DownloadString(url);
                JObject jObj = JObject.Parse(jsonStr);
                //избавляемся от вложенности и конвертим в словарь.
                JToken jList = (jObj["Valute"]);
                jObj = (JObject)jList;
                var courses = jObj.ToObject<Dictionary<string, Valute>>();

                foreach (var item in courses)
                {
                    _da.Add(item.Value);
                }
            }         

        }

        public decimal Convert(string charCode1, string charCode2, decimal ammount)
        {
            var valute1 = _da.GetByCharCode(charCode1);
            var valute2 = _da.GetByCharCode(charCode1);

            return  (valute1.Value / valute1.Nominal * ammount) / valute2.Value;         

        }

       
        public IEnumerable<Valute> GetValutesList()
        {
            return _da.GetAll();
        }
    }
}
