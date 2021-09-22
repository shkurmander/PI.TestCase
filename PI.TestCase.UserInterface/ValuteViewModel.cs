
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net;

namespace PI.TestCase.UserInterface
{
    public class Valute
    {
        public string Id { get; set; }
        public int NumCode { get; set; }
        public string CharCode { get; set; }
        public int Nominal { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal Previous { get; set; }
    }

    public class ValuteViewModel : INotifyPropertyChanged
    {
        const string URL = "https://www.cbr-xml-daily.ru/daily_json.js";
        public ObservableCollection<Valute> Data { get; set; } = new ObservableCollection<Valute>();
       

        public event PropertyChangedEventHandler PropertyChanged;

        public string CharCode { get; set; }
        public string Name { get; set; }

       
        public void Load()
        {

            Data.Add(new Valute()
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
                    Data.Add(item.Value);
                }
            }

        }
    }
}
