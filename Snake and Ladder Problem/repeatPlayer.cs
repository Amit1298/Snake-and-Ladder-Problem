using System;

namespace repeatStart
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int final = 100;
            int n;
            Random random = new Random();
            n = random.Next(95, 101);
            if (n == final)
            {
                Console.WriteLine("Starts from Starting Position");
            }
            else
            {
                Console.WriteLine("Play Continously");
            }
        }
    }
}
