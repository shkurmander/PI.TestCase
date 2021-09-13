using PI.TestCase.BLL.Interface;
using PI.TestCase.DAL.Interface;
using PI.TestCase.Entities;
using System;
using System.Collections.Generic;
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
        }

        public decimal Convert(string charCode1, string charCode2, decimal ammount)
        {
            var valute1 = _da.GetByCharCode(charCode1);
            var valute2 = _da.GetByCharCode(charCode1);

            return  (valute1.Value / valute1.Nominal * ammount) / valute2.Value;         

        }

        public void LoadData()
        {
            String url = "https://www.cbr-xml-daily.ru/daily_json.js"; 
            WebClient client = new WebClient(); 
            String jsonStr = client.DownloadString(url);
            var valuteList = JsonSerializer.Deserialize<List<Valute>>(jsonStr);
            foreach (var item in valuteList)
            {
                _da.Add(item);
            }           
            
        }
    }
}
