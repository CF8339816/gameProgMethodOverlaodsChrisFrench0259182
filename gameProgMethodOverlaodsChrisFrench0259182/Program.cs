using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace gameProgMethodOverlaodsChrisFrench0259182
{


    //Random random = new Random();
    //int randomNumber = random.Next(  ,  );



    internal class Program
    {

        static int sides;
        static int times;
        static Random random = new Random();





        static void Main(string[] args)
        {
            //Random random = new Random();
            //int roll = random.Next(1, sides + 1 );

            SixSide();
            randSide();
            RandSidesTimes();








        }

       //methods below here 
       //m1
       static void  SixSide()
        {
            sides = 6;
                      
            Console.WriteLine($" roll a 6  sided dice  ");
            int roll = random.Next(1, sides + 1);

            Console.WriteLine($" you rolled a {roll}");
            Console.ReadKey(true);

        }



        //m2
        static void randSide()
        {
            
            Console.WriteLine($" how many sides does your Die have?");
           
            sides = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine($" roll a {sides} sided dice ");
            int roll = random.Next(1, sides + 1);
            Console.WriteLine($" you rolled a {roll}");
            Console.ReadKey(true);


        }

        //m3
        static void RandSidesTimes()
        {

            Console.WriteLine($" how many sides does your Die have?");
            sides = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" how many times will you  rool your die?");
            times = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" roll a {sides} sided dice ");
            int roll = random.Next(1, sides + 1);



            Console.WriteLine($" you rolled a {roll}");
            Console.ReadKey(true);


        }


        //m4
        static void RandRed()
        {

            //Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" how many sides does your Die have?");
            sides = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" how many times will you  rool your die?");
            times = Convert.ToInt32(Console.ReadLine());
            Console.Write($" roll a ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{sides} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"sided dice ");
            int roll = random.Next(1, sides + 1);

            Console.Write($" you rolled a ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{sides} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"sided dice ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{times} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"timmes ");
            Console.Write($" you rolled a ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{roll} ");
            Console.ForegroundColor = ConsoleColor.White;

        
            Console.ReadKey(true);


            Console.ForegroundColor = ConsoleColor.White;
        }



        ////m5



        ////m6













    }
}
