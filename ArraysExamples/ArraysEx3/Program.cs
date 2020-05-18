using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEx3
{
    /*
    C# Program to Search an element with Array Indices

    Problem Solution
    Here the the element is searched in the array.

    Program Explanation
    This C# program is used to search an element with array indices. We have already defined 
    the values of ‘ints[]’ array variable. Using for loop print the coefficient element values
    present in the ints[] array variable.

    The Findobject() function uses the BinarySearch() function to search an array element. 
    Nested if else condition statement is used to check that the value of ‘index’ variable is 
    greater than 0. If the condition is true then execute the statement and print the index of 
    the value present in the array.

    Otherwise, if the condition is false then execute else if condition statement. Check the 
    value of ‘index’ variable is equal to the length of the array variable. If the condition 
    is true then execute the else if statement and print the statement as the value is not found in the array.

    Otherwise, if the condition is false then execute the else statement and print the larger object 
    found in the array index value.
    */
    class ArrayBinarySearch
    {
        public static void Main()
        {
            int[] ints = { 0, 10, 100, 1000, 1000000 };
            Console.WriteLine("Array indices and elements: ");
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write("[{0}]={1, -5}", i, ints[i]);
            }
            Console.WriteLine();
            FindObject(ints, 25);
            FindObject(ints, 1000);
            FindObject(ints, 2000000);
            Console.ReadLine();
        }

        public static void FindObject(Array array, Object o)
        {
            int index = Array.BinarySearch(array, 0, array.Length, o);
            Console.WriteLine();
            if (index > 0)
            {
                Console.WriteLine("Object: {0} found at [{1}]", o, index);
            }
            else if (~index == array.Length)
            {
                Console.WriteLine("Object: {0} not found. "
                   + "No array object has a greater value.", o);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Object: {0} not found. "
                   + "Next larger object found at [{1}].", o, ~index);
            }
        }
    }
}
