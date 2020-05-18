using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEx1
{
    /*
  * C# Program to get the Length of the Array
  * Problem Solution
  * Here the length of 1-Dimensional and 2-Dimensional array is found using the Length method.
  * 
  * Program Explanation
  * In this C# program, we are reading the size of the array for ‘arrayA’ and ‘twoD’ array variables. 
  * The length of 1-Dimensional and 2-Dimensional array is found using the Length method. Print the 
  * length of the array.
  */
    class Program
    {
        static void Main()
        {

            int[] arrayA = new int[5];
            int lengthA = arrayA.Length;
            Console.WriteLine("Length of ArrayA : {0}", +lengthA);
            long longLength = arrayA.LongLength;
            Console.WriteLine("Length of the LongLength Array  : {0}", longLength);
            int[,] twoD = new int[5, 10];
            Console.WriteLine("The Size of 2D Array is : {0}", twoD.Length);
            Console.ReadLine();
        }
    }
}