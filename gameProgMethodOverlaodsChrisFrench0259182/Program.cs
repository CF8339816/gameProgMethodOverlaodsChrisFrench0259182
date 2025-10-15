using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace gameProgMethodOverlaodsChrisFrench0259182
{




    internal class Program
    {

        static int sides;
        static int times;
        static Random random = new Random();
        




        static void Main(string[] args)
        {
            int roll = random.Next(1, sides + 1);






            rolldice();
            Console.WriteLine();
            rolldice(sides);
            Console.WriteLine();
            rolldice(sides, times);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            rolldice(sides, times);
            Console.ForegroundColor = ConsoleColor.White;
                
            Console.WriteLine();








            //Non overloaded code that  works 
            //SixSide();
            //Console.WriteLine();

            //randSide();
            //Console.WriteLine();

            //RandSidesTimes();
            //Console.WriteLine();

            //RandRed();
            //Console.WriteLine();




        }

        //methods below here 

        static void rolldice()
        {
            sides = 6;

            Console.WriteLine($" roll a 6  sided dice  ");
            int roll = random.Next(1, sides + 1);

            Console.WriteLine($" you rolled a {roll}");
            Console.ReadKey(true);
        }



        static void rolldice(int sides)
        {
            Console.WriteLine($" how many sides does your next Die have?");

            sides = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" roll a {sides} sided dice ");
            int roll = random.Next(1, sides + 1);
            Console.WriteLine($" you rolled a {roll}");
            Console.ReadKey(true);
        }

        static void rolldice(int sides, int times)
        {
            Console.WriteLine($" how many sides does your next Die have?");
            sides = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" how many times will you  roll your die?");

            string timesInput = Console.ReadLine();
            int.TryParse(timesInput, out times);

            for (int i = 0; i < times; i++)
            {
                int randomNumber = random.Next(1, sides + 1);
                Console.WriteLine($"Random number {i + 1}: {randomNumber}");
            }


            Console.ReadKey(true);
        }











        //Non overloaded code that  works 

        ////m1
        //static void  SixSide()
        //{
        //    sides = 6;

        //    Console.WriteLine($" roll a 6  sided dice  ");
        //    int roll = random.Next(1, sides + 1);

        //    Console.WriteLine($" you rolled a {roll}");
        //    Console.ReadKey(true);

        //}



        ////m2
        //static void randSide()
        //{

        //    Console.WriteLine($" how many sides does your next Die have?");

        //    sides = Convert.ToInt32( Console.ReadLine() );
        //    Console.WriteLine($" roll a {sides} sided dice ");
        //    int roll = random.Next(1, sides + 1);
        //    Console.WriteLine($" you rolled a {roll}");
        //    Console.ReadKey(true);


        //}

        ////m3
        //static void RandSidesTimes()
        //{

        //    Console.WriteLine($" how many sides does your next Die have?");
        //    sides = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine($" how many times will you  roll your die?");

        //    string timesInput = Console.ReadLine();
        //    int.TryParse(timesInput, out times);

        //    for (int i = 0; i < times; i++)
        //    {
        //        int randomNumber = random.Next(1, sides + 1); 
        //        Console.WriteLine($"Random number {i + 1}: {randomNumber}");
        //    }


        //    Console.ReadKey(true);


        //}


        ////m4
        //static void RandRed()
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine($" how many sides does your next Die have?");
        //    sides = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine($" how many times will you  roll your die?");

        //    string timesInput = Console.ReadLine();
        //    int.TryParse(timesInput, out times);

        //    for (int i = 0; i < times; i++)
        //    {
        //        int randomNumber = random.Next(1, sides + 1); 
        //        Console.WriteLine($"Random number {i + 1}: {randomNumber}");
        //    }

        //    Console.ReadKey(true);


        //    Console.ForegroundColor = ConsoleColor.White;
        //}



        ////m5



        ////m6













    }
}
