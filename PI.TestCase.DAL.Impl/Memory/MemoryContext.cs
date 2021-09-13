using PI.TestCase.Entities;
using System.Collections.Generic;

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
