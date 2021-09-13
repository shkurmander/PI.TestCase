
using Microsoft.Extensions.Configuration;
using PI.TestCase.Entities.Config;
using PI.TestCase.IoC;
using PI.TestCase.Mappers;
using PI.TestCase.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace TestConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();
            var configDal = configuration.GetSection("configurationDal").Get<ConfigDal>();
            var resolver = new DependencyResolver(configDal);
            var bll = resolver.ValuteSrvc;

            //Получаем список валют
            var valuteLst = new List<ValuteModel>();
            var tmpLst = bll.GetValutesList();
            foreach (var item in tmpLst)
            {
                valuteLst.Add(ValuteMapper.ToPL(item));
            }


            var result = bll.Convert("EUR", "USD", 10);

            Console.WriteLine($"Результат ", result);





        }
    }
}
