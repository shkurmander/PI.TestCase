using PI.TestCase.DAL.Interface;
using PI.TestCase.Entities;
using System.Collections.Generic;
using System.Linq;


namespace PI.TestCase.DAL.Impl
{
    public class ValuteSqlRepository : IValuteRepository
    {
        private readonly ValuteSqlContext _db;
        public ValuteSqlRepository(string dbconnection)
        {
            _db = new ValuteSqlContext(dbconnection);
        }

        public void Add(Valute newValute)
        {
            _db.Add(newValute);
            Save();
        }

        public void Delete(string id)
        {
            var item = _db.Valutes.Find(id);
            _db.Valutes.Remove(item);
            Save();
        }

        public void Update(Valute newValute)
        {
            _db.Find<Valute>(newValute);
            Save();
        }

        public IEnumerable<Valute> GetAll()
        {
            return _db.Valutes.ToList();
        }

        public Valute GetByCharCode(string charCode)
        {
            return _db.Valutes.SingleOrDefault(v => v.CharCode == charCode);                   
            
        }

        public Valute GetById(string id)
        {
            return _db.Valutes.SingleOrDefault(v => v.Id == id);
        }

        public IEnumerable<Valute> GetByName(string name)
        {
            return _db.Valutes.Where(v => v.Name.Contains(name)).ToList();
        }

        private void Save()
        {
            _db.SaveChanges();
        }
    }
}
