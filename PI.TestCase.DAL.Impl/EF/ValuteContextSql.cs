using Microsoft.EntityFrameworkCore;
using PI.TestCase.Entities;

namespace PI.TestCase.DAL.Impl.EF
{
    public class ValuteContextSql : DbContext
    {
        private string _dbconnection;
        public DbSet<Valute> Targets { get; set; }


        public ValuteContextSql(string dbconnection)
        {
            _dbconnection = dbconnection;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbconnection);
        }
    }
}
