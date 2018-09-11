using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClasses
{
    public class HorseDataClass
    {
        public string Name { get; set; }
        public string Odds { get { return String.Format("{0}/{1}", Numerator, Denominator); } }
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public decimal ImpliedProbability { get { return calImpliedProbability(); } }
        public decimal PercentageChance { get; set; }
        public int PercentageChanceFull { get { return (int)Math.Round(PercentageChance, 0);  } }

        private decimal calImpliedProbability()
        {
            decimal value = 0;

            if (Numerator <= 0 && Denominator <= 0)
                return value;
            //int to decimal convertion is needed to make sure we get a decimal place
            decimal num = decimal.Parse(Numerator.ToString());
            decimal den = decimal.Parse(Denominator.ToString());
            value = num / den;

            value += 1;

            return value;
        }



    }
}

