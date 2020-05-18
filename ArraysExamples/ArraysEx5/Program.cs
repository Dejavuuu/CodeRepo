using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEx5
{
    /*
    C# Program to Reverse an Array

    Problem Solution
    Here Array.Reverse inverts the ordering of an array’s elements.

    Program Explanation
    In this C# program, we have defined the value of ‘array’ variable. 
    Using foreach loop print the array values. The Array.Reverse() function
    is used to invert the ordering of an array’s elements using foreach loop. 
    Print the reverse of a value of ‘array’ variable.
    */
    using System;
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int a in array)
            {
                Console.WriteLine(a);
            }
            Array.Reverse(array);
            Console.WriteLine("Reversed Array : ");
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
