using PI.TestCase.Entities;
using System.Collections.Generic;


namespace PI.TestCase.DAL.Interface
{
    public interface IValuteRepository
    {
        IEnumerable<Valute> GetAll();
        public Valute GetById(string id);
        public IEnumerable<Valute> GetByName(string name);
        public Valute GetByCharCode(string charCode);
        public void Add(Valute newValute);
        public void Update(Valute newValute);
        public void Delete(string id);
    }
}
