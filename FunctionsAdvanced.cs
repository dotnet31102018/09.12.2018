using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions0912
{
    class Program
    {

        static void foo1(int[] secret)
        {
            secret[10] = 100;
        }

        static void add1(ref int y, ref int z)
        {
            y = y + 1;
            z = z + 1;
        }

        static void Main(string[] args)
        {

            int[] arr = new int[15];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            foo1(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("add1");
            int x = 10;
            int t = 10;
            add1(ref x, ref t);
            Console.WriteLine($"x is {x}");
            Console.WriteLine($"t is {t}");

            int[] newIntArray_X;
            int[] newIntArray_Y;
            CreateArray(out newIntArray_X, out newIntArray_Y);
            for (int i = 0; i < newIntArray_X.Length; i++)
            {
                Console.WriteLine(newIntArray_X[i]);
            }
            for (int i = 0; i < newIntArray_Y.Length; i++)
            {
                Console.WriteLine(newIntArray_Y[i]);
            }

            int z1, z2;
            ChangeZ(out z1, out z2);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(Numbers(4, 10, 12, -8, 111));

            Console.WriteLine(mul(x));
            Console.WriteLine(mul(x));

            goo(x:10, z: 30);
        }

        static void goo(int x, int y = 2, int z = 3)
        {
            if (x > y)
                Console.WriteLine(x);
            else
                Console.WriteLine(y);
        }

        private static int mul(int x, int y = 1) // default values must be aligned to the right!!!
        {
            return x * y;
        }

        private static int Numbers(params int[] arrayOfNumber)
        {
            int sum = 0;
            for (int i = 0; i < arrayOfNumber.Length; i++)
            {
                sum = sum + arrayOfNumber[i];
            }
            return sum;
        }
        private static void ChangeZ(out int z1, out int z2)
        {
            z1 = Convert.ToInt32(Console.ReadLine());
            z2 = Convert.ToInt32(Console.ReadLine());
        }

        private static void CreateArray(out int[] x, out int[] y)
        {
            x = new int[10];
            y = new int[10];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = i;
                y[i] = i;
            }
        }
    }
}
