using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEx8
{
    /*
 C# Program to Get 2 Arrays as Input and Produce a 3rd Array by Appending one to 
 other
Problem Description
This C# Program Gets 2 Arrays as Input and Produce a 3rd Array by Appending one to other.

Problem Solution
Here Buffer.BlockCopy is used to merge two int arrays. This method acts upon bytes, not elements.

Program Explanation
This C# program is used to get 2 arrays as input and produce a 3rd array by appending one to other.
Using for loop we are entering the coefficient element values for the array1 and array2 variables.
The Buffer.BlockCopy() function is used to merge two int arrays. This method acts upon bytes, not 
elements. Using foreach loop print the elements in third array after appending with first and second arrays.
Here the foreach statement is used to iterate through the collection to get the information that you want, 
but cannot be used to add or remove items from the source collection to avoid unpredictable side effects.
 */
    using System;

    class Program
    {
        static void Main()
        {
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] array3 = new int[array1.Length + array2.Length];
            Console.WriteLine("Enter Any 5 Elements for the First Array :");
            for (int i = 0; i < 5; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Any 5 Elements for the Second Array :");
            for (int i = 0; i < 5; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            Buffer.BlockCopy(array1, 0, array3, 0, array1.Length * sizeof(int));
            Buffer.BlockCopy(array2, 0, array3, array1.Length * sizeof(int),
                             array2.Length * sizeof(int));
            Console.WriteLine("Elements in the Third Array After Appending" +
                              " First and Second Arrays :");
            foreach (int value in array3)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
