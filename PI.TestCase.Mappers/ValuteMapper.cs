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

        //public static Valute ToBLL(Valute valute)
        //{
        //    if (valute == null) return null;

        //    return new Valute
        //    {
        //        Name = valute.Name,
        //        CharCode = valute.CharCode,
        //        Id = "",
        //        NumCode = 0,
        //        Nominal = 0,
        //        Value = 0,
        //        Prevous = 0
        //    };
        //}




    }
}
