using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic13
{
    class Program
    {
        // print 1 to 255
        static void range255()
        {
            Console.WriteLine("1 to 255:");
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*******************************************");
        }
        static void odd255()
        {
            Console.WriteLine("Odd numbers from 1 to 255:");
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("*******************************************");
        }
        static void TotalSum()
        {
            Console.WriteLine("Total of adding every number from 1 to 255:");
            var x = 0;
            for (int i = 0; i <= 25; i++)
            {
                x += i;
                Console.WriteLine(i + " Sum: " + x);
                
            }
            Console.WriteLine("*******************************************");
        }
        static void iterating()
        {
            Console.WriteLine("Iteating through an array:");
            int[] numarray = {1,3,5,7,9,13};

            foreach (int item in numarray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*******************************************");
        }
        static void arrMax()
        {
            Console.WriteLine("This is the max of the array:");
            int[] numarray = {1,3,5,7,9,13};
            int sum = numarray.Max();
            Console.WriteLine(sum);
            Console.WriteLine("*******************************************");
        }
        static void arrAvg()
        {
            Console.WriteLine("This is the average of the array:");
            int[] numarray = {1,3,5,7,9,13};
            Console.WriteLine(numarray.Average());          
            Console.WriteLine("*******************************************");
        }
        static void oddArr()
        {
            int [] oddnum;
            for (int i = 0; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    oddnum = new int[] {i};
                }
            }
            Console.WriteLine("This is a array of odd numbers");
                  
            Console.WriteLine("*******************************************");
        }
        static void greaterthan()
        {
            int[] array2 = {1,2,3,4,5,6,7,8,9,10};
            for (int idx = 0; idx < array2.Length; idx++)
            {
                if (array2[idx] < 4)
                {
                    Console.WriteLine(array2[idx]);
                }
            }
        }
        static void squared()
        {
            int[] array3 = {1,5,10,-2};
            for (int idx = 0; idx < array3.Length; idx++)
            {
                int x = array3[idx] * array3[idx];
                Console.WriteLine(x);
            }
        }
        static void getrid()
        {
            int[] array3 = {1,5,10,-2};
            for (int idx = 0; idx < array3.Length; idx++)
            {
                if (array3[idx] < 0)
                {
                    array3[idx] = 0;
                }
                Console.WriteLine(array3[idx]);
            }
        }
        static void ninmaxavg()
        {
            int[] array3 = {1,5,10,-2};
            Console.WriteLine("Minimum: "+ array3.Min());
            Console.WriteLine("Max:" + array3.Max());
            Console.WriteLine("Average: " + array3.Average());

        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            //range255();
            //odd255();
            //TotalSum();
            //iterating();
            //arrMax();
            //arrAvg();
            //oddArr();
            //greaterthan();
            //squared();
            //getrid();
            ninmaxavg();
        }
    }
}
