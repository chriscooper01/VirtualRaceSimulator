using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceCore
{
    public class HorseRacing
    {

        public static bool CreateHorse(string name, int numerator, int denominator, ref DataClasses.HorseDataClass horse)
        {
            horse = new DataClasses.HorseDataClass();
            if (!HorseRacingHorseValidation.ValidateName(name))
                return false;

            if (!HorseRacingHorseValidation.ValidateOdd(numerator, denominator))
                return false;


            horse.Name = name;
            horse.Denominator = denominator;
            horse.Numerator = numerator;
            return true;

        }
        


        public static void Race(List<DataClasses.HorseDataClass> horses, ref DataClasses.HorseDataClass winner)
        {
            decimal margin = HorseRacingMargin.CalculateMargin(horses);
            calChance(margin, ref horses);
            pickWinner(horses, ref winner);

        }


        private static void calChance(decimal margin, ref List<DataClasses.HorseDataClass> horses)
        {
            Console.WriteLine("Calculating chance");
            foreach (var horse in horses)
            {

                decimal answer = horse.ImpliedProbability  / margin;
                answer *= 100;
                horse.PercentageChance = answer;
                decimal percentageRounded = Math.Round(horse.PercentageChance, 1);
                Console.WriteLine(String.Format(" Horse {0} has a {1}% chance of winning", horse.Name, percentageRounded));
            }
            Console.WriteLine("");
        }
        
        private static void pickWinner(List<DataClasses.HorseDataClass> horses, ref DataClasses.HorseDataClass winner)
        {
            var rnd = new Random();
            var result = horses.OrderBy(item => rnd.Next()).First();
            winner = result;
        }

        

    }
}
