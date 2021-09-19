using Newtonsoft.Json.Linq;
using PI.TestCase.BLL.Interface;
using PI.TestCase.DAL.Interface;
using PI.TestCase.Entities;
using System;
using System.Collections.Generic;
using System.Net;

namespace PI.TestCase.BLL.Impl
{
    public class ValuteService : IValuteService
    {
        const String URL= "https://www.cbr-xml-daily.ru/daily_json.js";
        private readonly IValuteRepository _da;
        public ValuteService(IValuteRepository da)
        {
            _da = da;
            LoadData();
        }

        public void LoadData()
        {

            _da.Add(new Valute()
            {
                Id = "00000",
                NumCode = 810,
                CharCode = "RUB",
                Nominal = 1,
                Name = "Российский рубль",
                Value = 1,
                Previous = 1
            });

            using (WebClient client = new WebClient())
            {
                var jsonStr = client.DownloadString(URL);
                var jObj = JObject.Parse(jsonStr);
                //избавляемся от вложенности и конвертим в словарь.
                var jList = (jObj["Valute"]);
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
            if (charCode2 == "RUB")
            {
                return valute1.Value / valute1.Nominal * ammount;
            }
            var valute2 = _da.GetByCharCode(charCode2);
            
            return  (valute1.Value / valute1.Nominal * ammount) / valute2.Value; 
        }

       
        public IEnumerable<Valute> GetValutesList()
        {
            return _da.GetAll();
        }
    }
}
