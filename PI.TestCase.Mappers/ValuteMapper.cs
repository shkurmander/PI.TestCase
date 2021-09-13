using PI.TestCase.Models;
using PI.TestCase.Entities;


namespace PI.TestCase.Mappers
{
    public static class ValuteMapper
    {
        public static ValuteModel ToPL(Valute valute)
        {
            if (valute == null) return null;

            return new ValuteModel
            {
                Name = valute.Name,
                CharCode = valute.CharCode                
            };
        }
    }
}
