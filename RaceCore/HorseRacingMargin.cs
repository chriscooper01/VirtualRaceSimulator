using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceCore
{
    public class HorseRacingMargin
    {
        private const decimal MARGIN = 100;

        public static decimal CalculateMargin(List<DataClasses.HorseDataClass> horses)
        {
            decimal answer = 0;

            foreach(var horse in horses)
            {
                decimal loopAnswer = 0;
                loopAnswer = MARGIN / horse.ImpliedProbability;
                answer += loopAnswer;

            }
            return answer;
        }
    }
}
