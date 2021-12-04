using System;

namespace Recursion
{
    class Program
    {
        static void Main()
        {
            int count = 5;

            Countdown(count);

            Console.ReadKey();
        }

        private static void Countdown(int count)
        {         
            if (count < 1)
            {
                return;
            }
            Console.WriteLine(count);
            Countdown(count - 1);

        }
    }
}
