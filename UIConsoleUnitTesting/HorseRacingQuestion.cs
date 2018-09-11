using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsoleUnitTesting
{
    public class HorseRacingQuestion
    {
        private const int TOTALRACES = 1000000;
        /// <summary>
        /// This will do a simple test to show that this application can return example answer on question sheet
        /// </summary>
        public static void TestRace()
        {
            Console.WriteLine("Creating horses");
            List<DataClasses.HorseDataClass> horses = new List<DataClasses.HorseDataClass>();
            createHorses(ref horses);
            decimal margin = RaceCore.HorseRacingMargin.CalculateMargin(horses);
            DataClasses.HorseDataClass winner = new DataClasses.HorseDataClass();
            int loop = 0;
            List<DataClasses.UnitTestingWinnerStatsDataClass> horseWonStats = new List<DataClasses.UnitTestingWinnerStatsDataClass>();
            while (loop < TOTALRACES)
            {
                RaceCore.HorseRacing.Race(horses, ref winner);
                Console.WriteLine(String.Format(" {3}/{4} Horse {0} has a {1}% chance of winning has had the Odds of {2} has WON", winner.Name, winner.Odds, Math.Round(winner.PercentageChance, 1),loop,TOTALRACES));
                loop++;
                setStats(winner, ref horseWonStats);
            }
            Console.WriteLine("");
            Console.WriteLine(String.Format("{0} races have now completed.  Press key to see stats",TOTALRACES));
            showStats(horseWonStats);
            Console.ReadKey();


        }

        private static void createHorses(ref List<DataClasses.HorseDataClass> horses)
        {
            horses = new List<DataClasses.HorseDataClass>();

            DataClasses.HorseDataClass horse = new DataClasses.HorseDataClass();

            
            if (RaceCore.HorseRacing.CreateHorse("One over two", 1, 2, ref horse))
                horses.Add(horse);
            
            if (RaceCore.HorseRacing.CreateHorse("Two over one", 2, 1, ref horse))
                horses.Add(horse);
            
            if (RaceCore.HorseRacing.CreateHorse("Three over one", 3, 1, ref horse))
                horses.Add(horse);
            
            if (RaceCore.HorseRacing.CreateHorse("Eight over one", 8, 1, ref horse))
                horses.Add(horse);


            Console.WriteLine("Horses created details");
            foreach (var item in horses)
                Console.WriteLine(String.Format("  Name {0}, numerator {1}, denominator {2}, Odd {3}, Implied probability {4}", item.Name, item.Numerator, item.Denominator, item.Odds, item.ImpliedProbability.ToString("#.#")));

            Console.WriteLine("All look good? (Nothing will come from your answer, press key to continue)");
            Console.ReadKey();
            Console.WriteLine("");
        }

        private static void setStats(DataClasses.HorseDataClass winner, ref List<DataClasses.UnitTestingWinnerStatsDataClass> horseWonStats)
        {

            var current = horseWonStats.FirstOrDefault(x => x.Percent.Equals(winner.PercentageChance));
            if(current != null)
            {
                current.Total++;
            }else
            {
                horseWonStats.Add(new DataClasses.UnitTestingWinnerStatsDataClass() { Total = 1, Percent = winner.PercentageChance });
            }


        }

        private static void showStats(List<DataClasses.UnitTestingWinnerStatsDataClass> horseWonStats)
        {

            foreach(var item in horseWonStats)
            {
                Console.WriteLine(String.Format("Percent {0} has won {1} times", item.Percent, item.Total));
            }
            Console.ReadKey();
        }
    }
}
