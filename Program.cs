using System.ComponentModel.Design;
using System.Net;
using static System.Console;
using static System.Formats.Asn1.AsnWriter;

namespace LoopsDemo
{

    internal class Program
    {
        
        static void Main(string[] args)

        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Title = "Loops Demo";
            Console.WriteLine("````Loops Demo````");

            // While loop that counts from 0 to 10
            WriteLine("\n=== While Demo===\n");
            int i = 0;  
            while (i <=10)
            {
                WriteLine($"The count is {i}.");
                //i++;
               // i += 1;
               i = i +1;
            }
            // DO-while loop that counts from 10 to 1.
            WriteLine("\n=== Do-While Demo ===\n");
            int o =10;

            do

            {
                WriteLine($"The backwards count is {o}.");
                o--;
            } while (o >=1);

            //For loop that count from 5 to 35 by 5s
            WriteLine("\n=== For Demo===\n");
            for (int s = 5; s <= 35; s += 5)
            {
                WriteLine($"Counting by 5s: {s}.");
            }

            //Mini shop
            WriteLine("\n===Welcome to the shop===");
            bool isResponseValid = false;
            string response;
            string score;
            do
            {


                WriteLine("I currently have:\n A) an apple\n B) a banana");
                response = ReadLine().Trim().ToUpper();
                if (response == "A" || response == "B")
                {
                    isResponseValid = true;
                }
                else
                {
                    WriteLine($"I dont have \"{response}\". Pick somenthing else.");
                    isResponseValid= false;
                }
               // if (response == "A")
               // {

                //}
               // else if (response == "B")
                //    WriteLine("Enjoy your banana");
               // {

               // } if (response == "C")
                 //   WriteLine("I dont know what you want, I dont have those");

               // {

               // }

            } while (!isResponseValid);

            if (response == "A")
            {
                WriteLine("Enjoy the apple.");
            }
            else 
            
            {
                WriteLine("Enjoy the banana");
            }

            static bool UseUmbrella(bool rainy, bool sunny, bool windy)
            {
                return !windy && (rainy || sunny);
            }
            Console.WriteLine(UseUmbrella(true, true, false));


            WriteLine("Press any key to exit...");
            ReadKey();
        }
    }
}