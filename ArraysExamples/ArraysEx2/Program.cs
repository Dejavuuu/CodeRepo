using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEx2
{
    /*
   * C# Program to Find Minimum and Maximum of Numbers
     Problem Solution
     Here the minimum and the maximum number is obtained with the help of min and max functions.

     Program Explanation
     This C# program is used to find minimum and maximum of numbers. Using array1 variable we have already defined the values, hence the minimum and the maximum number are obtained with the help of min and max functions.
   */
    class Program
    {
        static void Main()
        {
            int[] array1 = { 10, -10, -20, 0, 15, 20, 30 };
            Console.WriteLine("Maximum Element : " + array1.Max());
            Console.WriteLine("Minimum Element : " + array1.Min());
            Console.Read();
        }
    }
}