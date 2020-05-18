using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEx6
{
    /*
    C# Program to Sort a List of Names in Alphabetical Order

    Problem Solution
    Here the List of names are sorted with the help of sort function.

    Program Explanation
    In this C# program, using foreach loop print the names in alphabetical order. 
    The foreach statement is used to iterate through the collection to get the 
    information that we want, but cannot be used to add or remove items from the source 
    collection to avoid unpredictable side effects. Print the sorted list of names in 
    alphabetical order.
    */
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    namespace ConsoleApplication1
    {
        class Program
        {
            static void Main()
            {
                List<string> names = new List<string>();
                names.Add("Ram");
                names.Add("Rose");
                names.Add("Abs");
                names.Add("Edward");
                names.Add("Sita");
                names.Sort();
                foreach (string s in names)
                    Console.WriteLine(s);
                Console.ReadLine();
            }
        }
    }
}
