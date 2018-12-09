using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0912HW
{
    class Program
    {

        private static int CheckIfPrimeNumber(int number)
        {

            int m1 = 2;
            while (number % m1 != 0 && m1 < number)
            {
                m1++;
            }
            if (number == m1)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        private static void CheckForPrimeNumbersInArray(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                int result = CheckIfPrimeNumber(numbers[i]);

                if (result == 1)
                    Console.WriteLine($"The number {numbers[i]} is Prime");
                else
                    Console.WriteLine($"The number {numbers[i]} is NOT Prime");
            }
        }

        private static int SumArray(int[] array)
        {
            int sumArray = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sumArray = sumArray + array[i];
            }

            return sumArray;
        }

        private static int WhichArrayIsBigger(int[] array1, int[] array2)
        {
            int sumArray1 = SumArray(array1);
            int sumArray2 = SumArray(array2);

            if (sumArray1 > sumArray2)
            {
                return 1;
            }
            else if (sumArray1 == sumArray2)
            {
                return 0;
            }
            else
            {
                return -1;
            }

        }

        private static void CheckExist(int[,] matrix)
        {
            Console.WriteLine("Please enter a number to search in the matrix:");

            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == number)
                    {
                        Console.WriteLine($"{number} first existance is {i}, {j}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{number} missing");

        }
        private static int[,] FillRandom()
        {
            int[,] result = new int[10, 10];

            Random randomGenerator = new Random();

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] =  randomGenerator.Next(1, 101);
                }
            }

            return result;
        }

        private static void SortMyArray(int[] arrayForSort)
        {
            for (int i = 0; i < arrayForSort.Length; i++)
            {
                for (int j = i + 1; j < arrayForSort.Length; j++)
                {
                    if (arrayForSort[i] > arrayForSort[j])
                    {

                        // arrayForSort[i] = 5
                        // arrayForSort[j] = 8

                        int temp = arrayForSort[i]; // temp = 5

                        arrayForSort[i] = arrayForSort[j]; // arrayForSort[i] = 5 - > 8

                        arrayForSort[j] = temp; // arrayForSort[j] = 5
                    }
                }
            }
        }

        static void Main(string[] args)
        {

            // =============================== 1
            Console.WriteLine("Please enter a number:");

            int number = Convert.ToInt32(Console.ReadLine());

            int result = CheckIfPrimeNumber(number);

            if (result == 1)
                Console.WriteLine($"The number was Prime" );
            else
                Console.WriteLine($"The number was NOT Prime");


            // =============================== 2
            int[] arrayNumbers2 = { 2, 4, 9, 13, 17 };
            CheckForPrimeNumbersInArray(arrayNumbers2);

            // =============================== 3
            int[] arrayNumbersOne3 = { 5, 433, 29, 313, 174 };
            int[] arrayNumbersTwo3 = { 2, 6, -9, 130, 17 };
            int resultCompare = WhichArrayIsBigger(arrayNumbersOne3, arrayNumbersTwo3);
            Console.WriteLine($"The compare of two arrays result was : {resultCompare}");


            // =============================== 4
            int[,] matrix = FillRandom();
            for (int i = 0; i < 10; i++)
            {
                CheckExist(matrix);
            }

            // =============================== 5
            int[] arrayForSort = { 100, 5, 2, 15, 10, -5 };
            SortMyArray(arrayForSort);
            for (int i = 0; i < arrayForSort.Length; i++)
            {
                Console.Write(arrayForSort[i] + " , ");
            }


            Convert.ToInt32(Console.ReadLine());
        }


    }
}
