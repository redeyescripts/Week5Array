using System;

namespace Week5Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
           // int[] array1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            //foreach (int number in array1)
            {
               // Console.WriteLine(number);
            }
            int[] array4 = new int[10];

            for(int i = array4.Length - 1,j =0; i >= 0; i--,j++)
            {
                array4[j] = i +1;

            }
            foreach(int num in array4 )
            {
                Console.WriteLine(num);
            }
            Random rnd = new Random();
        int[] array5 = new int[10];

        for(int i =0; i < array5.Length; i++)
            {

                array5[i] = rnd.Next(1, 101);

            }
              foreach(int num in array5)
              {
                Console.WriteLine(num);
              }
        }  
        
          
            
            
    }
}
