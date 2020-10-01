


using System;
using System.Xml.Schema;

namespace Week5Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // int[] numbers - massiiv
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int number in array1)
            {
                Console.WriteLine(number);
            }
            //option 2
            int[] array2 = new int[10];
            array2[0] = 1;
            array2[1] = 2;
            array2[2] = 3;
            array2[3] = 4;
            array2[4] = 5;
            array2[5] = 6;
            array2[6] = 7;
            array2[7] = 8;
            array2[8] = 9;
            array2[9] = 10;
            foreach (int number in array2)
            {
                Console.WriteLine($"array 2: {number}");
            }
            //Option 3 auto populat array with numbers

            int[] array3 = new int[10];
            for (int i = 0; 1 < array3.Length; i++)
            {
                array3[i] = i+1;

            }
            foreach (int number in array3)
            {
                Console.WriteLine($"Array3:{number}");
            }
            int[] array4 = new int[10];
            array2[9] = 10;
            array2[8] = 9;
            array2[7] = 8;
            array2[6] = 7;
            array2[5] = 6;
            array2[4] = 5;
            array2[3] = 4;
            array2[2] = 3;
            array2[1] = 2;
            array2[0] = 1;
            foreach (int number in array4)
            {
                Console.WriteLine($"array 4: {number}");
            }
        }
    }
}
