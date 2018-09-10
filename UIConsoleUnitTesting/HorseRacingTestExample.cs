using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsoleUnitTesting
{
    public class HorseRacingTestExample
    {
        /// <summary>
        /// This will do a simple test to show that this application can return example answer on question sheet
        /// </summary>
        public static void TestMargin()
        {
            Console.WriteLine("Creating horses");
            List<DataClasses.HorseDataClass> horses = new List<DataClasses.HorseDataClass>();
            createHorses(ref horses);
            Console.WriteLine("Horses created");

            Console.WriteLine("");
            Console.WriteLine("Calulate margine");
            decimal margin = RaceCore.HorseRacingMargin.CalculateMargin(horses);
            Console.WriteLine(String.Format(" Margine: {0}",margin));
            
        }

        /// <summary>
        /// This will do a simple test to show that this application can return example answer on question sheet
        /// </summary>
        public static void TestRace()
        {
            Console.WriteLine("Creating horses");
            List<DataClasses.HorseDataClass> horses = new List<DataClasses.HorseDataClass>();
            createHorses(ref horses);
            Console.WriteLine("Horses created");

            Console.WriteLine("");
            Console.WriteLine("Calulate margine");
            decimal margin = RaceCore.HorseRacingMargin.CalculateMargin(horses);
            Console.WriteLine(String.Format(" Margine: {0}", margin));
            Console.WriteLine("");
            Console.WriteLine("Race");
            DataClasses.HorseDataClass winner = new DataClasses.HorseDataClass();
            RaceCore.HorseRacing.Race(horses, ref winner);
            Console.WriteLine(String.Format(" Horse {0} has a {1}% chance of winning has had the Odds of {2} has WON", winner.Name, winner.Odds,  Math.Round(winner.PercentageChance, 1)));
            Console.ReadKey();


        }

        private static void createHorses(ref List<DataClasses.HorseDataClass> horses)
        {
            horses = new List<DataClasses.HorseDataClass>();

            DataClasses.HorseDataClass horse = new DataClasses.HorseDataClass();
            
            Console.WriteLine(" One over two");
            if (RaceCore.HorseRacing.CreateHorse("One over two", 1, 2, ref horse))
                horses.Add(horse);
            Console.WriteLine(" two over one");
            if (RaceCore.HorseRacing.CreateHorse("Two over one", 2, 1, ref horse))
                horses.Add(horse);
            Console.WriteLine(" Three over one");
            if (RaceCore.HorseRacing.CreateHorse("Three over one", 3, 1, ref horse))
                horses.Add(horse);
            Console.WriteLine(" Eight over one");
            if (RaceCore.HorseRacing.CreateHorse("Eight over one", 8, 1, ref horse))
                horses.Add(horse);


            Console.WriteLine("Horses created details");
            foreach(var item in horses)
                Console.WriteLine(String.Format("  Name {0}, numerator {1}, denominator {2}, Odd {3}, Implied probability {4}",item.Name, item.Numerator,item.Denominator,item.Odds, item.ImpliedProbability.ToString("#.#")));

            Console.WriteLine("All look good? (Nothing will come from your answer, press key to continue)");            
            Console.ReadKey();
            Console.WriteLine("");
        }
    }
}
