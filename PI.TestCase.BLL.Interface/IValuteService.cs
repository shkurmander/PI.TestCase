using PI.TestCase.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
