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
            if (horses.Count.Equals(0))
                return;//No horses

            decimal margin = HorseRacingMargin.CalculateMargin(horses);

            if (margin < 110 && margin > 140)
                return;//Margin is not corret

            calChance(margin, ref horses);
            pickWinnerPercent(horses, ref winner);

        }


        private static void calChance(decimal margin, ref List<DataClasses.HorseDataClass> horses)
        {
            Console.WriteLine("Calculating chance");
            foreach (var horse in horses)
            {

                decimal answer = 100 / horse.ImpliedProbability;
                answer = answer / margin;
                answer *= 100;
                horse.PercentageChance = answer;
                decimal percentageRounded = Math.Round(horse.PercentageChance, 1);
                Console.WriteLine(String.Format(" Horse {0} has a {1}% chance of winning", horse.Name, percentageRounded));
            }
            Console.WriteLine("");
        }
        
        private static void pickWinnerRandom(List<DataClasses.HorseDataClass> horses, ref DataClasses.HorseDataClass winner)
        {
            var rnd = new Random();
            var result = horses.OrderBy(item => rnd.Next()).First();
            winner = result;
        }

        private static void pickWinnerPercent(List<DataClasses.HorseDataClass> horses, ref DataClasses.HorseDataClass winner)
        {
            var rnd = new Random();
            bool found = false;
            while(!found)
            {
                int percentValue = rnd.Next(0, 100);
                var result = horses.FirstOrDefault(x => x.PercentageChanceFull.Equals(percentValue));
                if(result !=null)
                {
                    winner = result;
                    found = true;
                    break;
                }
                

            }
            
            

            
        }



    }
}
