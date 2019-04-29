using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;
            var boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            int index = 1;
            while (index < 100000000)
            {
                do {
                    while (!Console.KeyAvailable)
                    {
                        if (IsPrime(index))
                        {
                            Console.WriteLine(index);
                        }
                        index++;
                    }
                } while (Console.ReadKey(true).Key != ConsoleKey.Spacebar);
                Console.ReadKey(true);
            }
        }
    }
}
