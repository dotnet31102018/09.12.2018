using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0912
{
    class Program
    {

        static bool IsPrimeNumber(int x)
        {

            int m1 = 2;
            while (x % m1 != 0 && m1 < x)
            {
                m1++;
            }
            if (x == m1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {

            bool vegeterian = true;
            bool iAmShort = false;

            if (vegeterian) // short for if (vegeterian == true)
            {
                Console.WriteLine("Love veggie");
            }

            if (!iAmShort) // short for if (iAmShort == false)
            {
                Console.WriteLine("Love veggie");
            }

            // read number from user [keyboard] and check if prime or not
            int number = Convert.ToInt32(Console.ReadLine());
            if (IsPrimeNumber(number))
            {
                Console.WriteLine("Prime!");
            }

            if (!IsPrimeNumber(number))
            {
                Console.WriteLine("NOT Prime!");
            }

            bool zugi = true; // 1 
            for (int i = 2; i < 100; i++)
            {
                if (zugi)
                {
                    Console.WriteLine($"{i} is Zugi");
                }
                else
                {
                    Console.WriteLine($"{i} is Ei zugi");
                }

                //if (zugi == true)
                //{
                //    zugi = false;
                //}
                //else
                //{
                //    zugi = true;
                //}
                zugi = !zugi;

            }

            string text = "hello world!";
            text = Console.ReadLine();
            Console.WriteLine(text);

        }
    }
}
