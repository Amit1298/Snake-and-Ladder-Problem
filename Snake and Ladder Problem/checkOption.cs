using System;

namespace checkOption
{
    class Program
    {
        static void Main(string[] args)
        {
            int noPlay = 0;
            int ladder = 1;
            int snake = 2;
            Random random = new Random();
            int checkOpt = random.Next(0, 3);
            if (checkOpt == noPlay)
            {
                Console.WriteLine("Player at Starting Position");
            }
            else if (checkOpt == ladder)
            {
                Console.WriteLine("Player reach to ladder");
            }
            else
            {
                Console.WriteLine("Player cut by Snake");
            }
        }
    }
}
