using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEx4
{
    /*
    C# Program to Negate the Positive Elements of Array

    Problem Solution
    The array elements are obtained from the user and the elements of the array are negated.

    Program Explanation
    This C# program, we are reading the value of 5 elements value using for loop and assign 
    the value to ‘a[]’ array variable. If condition statement is used to check the value of 
    ‘a[]’ variable is greater than 0. If the condition is true, then execute the statement. Assign 
    the value of ‘a[]’ variable to the minus symbol of a[] variable. Hence using foreach loop 
    print negate of positive elements of an array.
   */
    using System;
    using System.Collections.Generic;
    using System.Text;
    namespace program
    {
        class negate
        {
            public static void Main()
            {
                int[] a = new int[10];
                Console.WriteLine("Enter 5 Elements : ");
                for (int i = 0; i < 5; i++)
                {
                    a[i] = Convert.ToInt16(Console.ReadLine());
                    if (a[i] > 0)
                        a[i] = -a[i];
                }
                Console.WriteLine("Elements:");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(a[i]);
                }
                Console.ReadLine();
            }
        }
    }
}
