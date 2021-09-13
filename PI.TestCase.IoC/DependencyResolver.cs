using PI.TestCase.BLL.Impl;
using PI.TestCase.BLL.Interface;
using PI.TestCase.DAL.Impl;
using PI.TestCase.DAL.Interface;
using PI.TestCase.Entities.Config;
using System;

namespace PI.TestCase.IoC
{
    public class DependencyResolver
    {
        private readonly IValuteRepository _valuteRepo;
        public IValuteService ValuteSrvc { get; }
        public DependencyResolver(ConfigDal config)
        {
            _valuteRepo = GetRepository(config);
            ValuteSrvc = new ValuteService(_valuteRepo);
        }

        private IValuteRepository GetRepository(ConfigDal config)
        {
            switch (config.Type)
            {               
                case TypeOfStore.MSSQL:
                    return new ValuteSqlRepository(config.DbConnection);
                case TypeOfStore.Memory:
                    return new ValuteMemoryRepository();
                default:
                    throw new ArgumentException("Некорректный параметр конфигурации хранилища");
            }

        }
    }
}
