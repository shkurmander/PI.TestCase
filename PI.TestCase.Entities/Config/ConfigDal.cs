using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI.TestCase.Entities.Config
{
    public class ConfigDal
    {
        public TypeOfStore Type { get; set; }


        public string DbConnection { get; set; }
        public string FilePath { get; set; }
    }
}
