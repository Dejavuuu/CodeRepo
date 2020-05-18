using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExSnippets
{
    class Class1
    {
        /*
         Sorting array of primitive types
         To sort array of primitive types such as int, double or string use method Array.Sort(Array)
         with the array as a paramater.The primitive types implements interface IComparable, which 
         is internally used by the Sort method(it calls IComparable.Com­pareTo method). See example 
         how to sort int array:
         */
        public void sortInt()
        {
            // sort int array
            int[] intArray = new int[5] { 8, 10, 2, 6, 3 };
            Array.Sort(intArray);
            // write array
            foreach (int i in intArray) Console.Write(i + " ");  // output: 2 3 6 8 10
        }

        // or for String:

        public void sortString()
        {
            // sort int array
            int[] intArray = new int[5] { 8, 10, 2, 6, 3 };
            Array.Sort(intArray);
            // write array
            foreach (int i in intArray) Console.Write(i + " ");  // output: 2 3 6 8 10
        }

        /*
        Sorting array of custom type using delegate
        To sort your own types or to sort by more sophisticated rules, you can use delegate to anonymous method.
        The generic delegate Comparison<T> is declared as public delegate int Comparison<T>(T x, T y). It points 
        to a method that compares two objects of the same type.It should return less then 0 when X<Y, zero when 
        X = Y and greater then 0 when X > Y.The method (to which the delegate points) can be also an anonymous 
        method(written inline). Following example demonstrates how to sort an array of custom type using the delegate 
        to anonynous comparison method. The custom type in this case is a class User with properties Name and Age.
        */


        public void sortDelegate()
        {
            // array of custom type
            User[] users = new User[3] { new User("Betty", 23),  // name, age
                             new User("Susan", 20),
                             new User("Lisa", 25) };

            // sort array by name
            Array.Sort(users, delegate (User user1, User user2)
            {
                return user1.Name.CompareTo(user2.Name);
            });
            // write array (output: Betty23 Lisa25 Susan20)
            foreach (User user in users) Console.Write(user.Name + user.Age + " ");

            // sort array by age
            Array.Sort(users, delegate (User user1, User user2)
            {
                return user1.Age.CompareTo(user2.Age); // (user1.Age - user2.Age)
            });
            // write array (output: Susan20 Betty23 Lisa25)
            foreach (User user in users) Console.Write(user.Name + user.Age + " ");
        }

    }

    /*
     * Sorting array using IComparable
     * If you implement IComparable interface in your custom type, you can sort array 
     * easily like in the case of primitive types.The Sort method calls internally 
     * IComparable.Com­pareTo method.
    */
    public class User : IComparable
    {
        // ...

        // implement IComparable interface
        public int CompareTo(object obj)
        {
            if (obj is User)
            {
                return this.Name.CompareTo((obj as User).Name);  // compare user names
            }
            throw new ArgumentException("Object is not a User");
        }
    }
}
