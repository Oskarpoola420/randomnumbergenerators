using System;

namespace EpicDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string PlayerOne = "joe";
            string PlayerTwo = "mama";

            int joeThrow = rnd.Next(1, 7);
            int mamathrow = rnd.Next(1, 7);

            Console.WriteLine($"{PlayerOne} threw {joeThrow};");
            Console.WriteLine($"{PlayerTwo} threw {mamathrow};");
            if(joeThrow > mamathrow)
            {
                Console.WriteLine($"{PlayerOne} Wins!");
            }
            else if (joeThrow < mamathrow)
            {
                Console.WriteLine($"{PlayerTwo} Wins!");
            }
            else
            {
                Console.WriteLine("draw! let them try again.");
            }
        }
    }
}
