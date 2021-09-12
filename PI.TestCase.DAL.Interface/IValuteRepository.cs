using PI.TestCase.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
