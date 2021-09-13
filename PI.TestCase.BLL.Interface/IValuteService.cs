


using PI.TestCase.Entities;
using System.Collections.Generic;

namespace PI.TestCase.BLL.Interface
{
    public interface IValuteService
    {
        public decimal Convert(string charCode1, string charCode2, decimal ammount);
        public void LoadData();
        public IEnumerable<Valute> GetValutesList();


    }
}
