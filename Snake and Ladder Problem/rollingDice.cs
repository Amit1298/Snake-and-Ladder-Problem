using System;

namespace rollingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int dice;
            Random random = new Random();
            dice = random.Next(1, 7);
            Console.WriteLine("No. of shown in Dice is : " + dice);
        }
    }
}
