using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI.TestCase.Entities.Config
{
    public class TypeOfStore
    {
        public enum TypeOfDao
        {
            File = 0,
            MSSQL = 1,
            Memory = 2
        }
    }
}
