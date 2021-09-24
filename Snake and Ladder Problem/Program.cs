using System;

namespace Snake_and_Ladder_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int noStart = 0;

            Random random = new Random();
            int dice = random.Next(0,1);
            if (dice == noStart)
            {
                Console.WriteLine("Player at Starting Position");
            }
            else
            {
                Console.WriteLine("Player move forword");
            }
        }
    }
}
