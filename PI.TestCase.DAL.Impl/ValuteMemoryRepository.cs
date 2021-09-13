using PI.TestCase.DAL.Impl.Memory;
using PI.TestCase.DAL.Interface;
using PI.TestCase.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PI.TestCase.DAL.Impl
{
    class ValuteMemoryRepository : IValuteRepository
    {
        private readonly MemoryContext _db;
        public ValuteMemoryRepository()
        {
            _db = new MemoryContext();
        }
        public void Add(Valute newValute)
        {
            _db.Valutes.Add(newValute);
        }

        public void Delete(string id)
        {
            var item = GetById(id);
            _db.Valutes.Remove(item);
        }

        public IEnumerable<Valute> GetAll()
        {
            return _db.Valutes;
        }

        public Valute GetByCharCode(string charCode)
        {
            return GetAll().Where(item => item.CharCode.ToLower() == charCode.ToLower()).Single();
        }

        public Valute GetById(string id)
        {
            return GetAll().Where(item => item.Id == id).Single();
        }

        public IEnumerable<Valute> GetByName(string name)
        {
            return GetAll().Where(item => item.Name.ToLower().Contains(name.ToLower()));
        }

        public void Update(Valute newValute)
        {
            var result = _db.Valutes.SingleOrDefault(i => i.Id == newValute.Id);
            result.Id = newValute.Id;
            result.NumCode = newValute.NumCode;
            result.CharCode = newValute.CharCode;
            result.Nominal = newValute.Nominal;
            result.Name = newValute.Name;
            result.Value = newValute.Value;
            result.Prevous = newValute.Prevous;
            
        }
    }
}
