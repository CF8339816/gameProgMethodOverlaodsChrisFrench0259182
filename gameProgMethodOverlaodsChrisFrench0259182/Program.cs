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


          static string username;
         static int health;
        static int mana;


    static string playerName = "Jub Jub";
        static int playerhealth = 100;
        static int playermana = 100;


        static string gobName = "GobbGob";
        static int gobhealth = 50;
        static int gobmana = 25;


        static string orcName = "Thuganomics";
        static int orchealth = 150;
        static int orcmana = 50;


        static void Main(string[] args)
        {

            DisplayCharacterInfo(playerName, playerhealth, playermana, 0.5F);
            Console.ReadKey(true);
                
            DisplayCharacterInfo(gobName, gobhealth, gobmana);

            DisplayCharacterInfo(orcName, orchealth, orcmana);


        }

        static void DisplayCharacterInfo(string username, int health, int mana)
        {
            Console.WriteLine($"name:" + username);
            Console.WriteLine($"name:" + health);
            Console.WriteLine($"name:" + mana);
 
        }
       //way to assign a default would be 

   //static void DisplayCharacterInfo(int health, int mana, string username = "??????")
   //     {
   //         Console.WriteLine($"name:" + username);
   //         Console.WriteLine($"name:" + health);
   //         Console.WriteLine($"name:" + mana);

   //     }
        static void DisplayCharacterInfo(string username, int health, int mana, float specialAtk)
        {
            Console.WriteLine($"name:" + username);
            Console.WriteLine($"name:" + health);
            Console.WriteLine($"name:" + mana);

        }

        static void DisplayCharacterInfo()
        {
            Console.WriteLine($"name:" + playerName);
            Console.WriteLine($"name:" + playerhealth);
            Console.WriteLine($"name:" + playermana);

        }


     










    }
}
