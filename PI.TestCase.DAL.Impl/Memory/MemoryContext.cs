using PI.TestCase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI.TestCase.DAL.Impl.Memory
{
    public class MemoryContext
    {
        public List<Valute> Valutes { get; set; }
        public MemoryContext()
        {
            Valutes = new List<Valute>();
        }
    }
}
