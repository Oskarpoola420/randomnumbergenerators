using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int MyRandomNuber = rnd.Next(1, 11);
            //programm genereerib juhuslikku numbrit 1 kuni 10
            //programm kontrollib kas number on suurem kui 5
            // kui number on suure, kui 5, siis konsool kuvab
            //juhuslik number on {myrandomnumber} see on suurem kui 5
            // kui number on väiksem kui 5 konsool kuvab


            Console.WriteLine($"arvuti genereeris: {MyRandomNuber}");
            if(MyRandomNuber > 5)
            {
                Console.WriteLine($"juhuslik numbe on {MyRandomNuber}, see on suurem, kui 5");
            }
            else if (MyRandomNuber < 5)
            {
                Console.WriteLine($"juhuslik numbe on {MyRandomNuber}, see on väiksem, kui 5");
            }
            else
            {
                Console.WriteLine("juhuslik number ongi 5");
            }
        }
    }
}
