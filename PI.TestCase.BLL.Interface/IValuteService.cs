
using PI.TestCase.Entities;
using System.Collections.Generic;

namespace PI.TestCase.BLL.Interface
{
    public interface IValuteService
    {
        public IEnumerable<Valute> GetAll();
        public Valute GetById(string id);
        public IEnumerable<Valute> GetByName(string name);
        public Valute GetByCharCode(string charCode);
        public void Add(Valute newValute);
        public void Edit(string id);
        public void Delete(string id);        


    }
}
