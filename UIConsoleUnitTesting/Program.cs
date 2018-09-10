using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsoleUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            run();

        }

        private static void run()
        {
            
            var testToRun = getTest();
            switch(testToRun)
            {
                case DataClasses.UnitTestTypeENUM.ExampleMargin:
                    HorseRacingTestExample.TestMargin();
                    run();
                    break;
                case DataClasses.UnitTestTypeENUM.ExampleRace:
                    HorseRacingTestExample.TestRace();
                    run();
                    break;
                case DataClasses.UnitTestTypeENUM.Exit:                    
                    break;
            }

        }


        private static DataClasses.UnitTestTypeENUM getTest()
        {
            Console.WriteLine("What would you like to test?");
            Console.WriteLine(" - Example margin");
            Console.WriteLine(" - Example race");
            string line = Console.ReadLine();
            string value = line.Replace(" ", String.Empty).Trim().ToLower();
            if (value.Equals("examplemargin"))
                return DataClasses.UnitTestTypeENUM.ExampleMargin;

            if (value.Equals("examplerace"))
                return DataClasses.UnitTestTypeENUM.ExampleRace;

            if (value.Equals("exit"))
                return DataClasses.UnitTestTypeENUM.Exit;

            Console.WriteLine(" Oops, do not seem to have this test. If you want to exit, type exit");
            Console.WriteLine(" ");
            return getTest();
        }
    }
}
