using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEx7
{
    /*
    C# Program to Search an Element in an Array

    Problem Solution
    Here an array is declared and an element is searched and if found and displayed.

    Program Explanation
    In this C# program, we have already defined the value of ‘array1’ variable. Compute 
    the find() function to find an element starts with ‘cam’ variable using ‘StringComparison.Ordinal’. 
    It compares the strings based on the order of characters. Then another variable ‘v2’ is used to 
    find the length of an element whose size is 3. Print the searched element in an array.
    */
    using System;
    using System.IO;
    class Program
    {
        static void Main()
        {

            string[] array1 = { "cat", "dogs", "donkey", "camel" };
            string v1 = Array.Find(array1,
                element => element.StartsWith("cam", StringComparison.Ordinal));
            string v2 = Array.Find(array1,
                element => element.Length == 3);
            Console.WriteLine("The Elemnt that Starts with 'Cam' is : " + v1);
            Console.WriteLine("3 Letter word in the Array is : " + v2);
            Console.ReadLine();
        }
    }
}
