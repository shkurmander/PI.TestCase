using Microsoft.EntityFrameworkCore;
using PI.TestCase.Entities;

namespace PI.TestCase.DAL.Impl
{
    public class SqlContext : DbContext
    {
        private readonly string _dbconnection;
        public DbSet<Valute> Valutes { get; set; }

        public SqlContext(string dbconnection)
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
