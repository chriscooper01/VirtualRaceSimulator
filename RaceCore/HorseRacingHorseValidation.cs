using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceCore
{
    public class HorseRacingHorseValidation
    {
        private const int MAXCHARACTERS = 18;
        private const int MINCHARACTERS = 0;
        private const int MARGINMIN = 110;
        private const int MARGINMAX = 140;
        public static bool ValidateName(string name)
        {

            if (name.Trim().Length > MAXCHARACTERS)
                return false;


            if (name.Trim().Length < MINCHARACTERS)
                return false;


            return true;

        }

        public static bool ValidateOdd(int numerator, int denominator)
        {
            decimal answer = numerator + denominator;
            if (answer < 1)
                return false;

            return true;

        }


        public static bool ValidateMargin(decimal margin)
        {
            return (margin > MARGINMIN && margin < MARGINMAX);
        }

    }
}
