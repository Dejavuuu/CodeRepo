using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
            static void Main(string[] args)
            {
               
                var inputStr = takeInput();
                var isPalindrome = CheckStringForPalindome(inputStr);
            }



            /// <summary>
            /// This function does just one thing.  It takes the input value from Console.ReadLine
            /// </summary>
            /// <returns>string</returns>
            public static string takeInput()
            {

                Console.WriteLine("Please enter a word");
                var orginalStr = Console.ReadLine();

                return orginalStr;

            }


            /// <summary>
            /// This function takes the input string and checks if the string is a palindrome
            /// </summary>
            /// <param name="input"></param>
            /// <returns>bool</returns>
            static bool CheckStringForPalindome(string input)
            {

                char[] ch = input.ToCharArray();

                Array.Reverse(ch);
                var reverString = new string(ch);

                if(input == reverString)
                {
                    return true;
                }

                return false;
            }

        }
    }



/*using

/*using System;

    //program 1
namespace PalindromeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Coffee is Life");
            takeInput();
        }

        public static void takeInput()
        {
            Console.WriteLine("Please enter you name?");
            var userInput = "";
            userInput = Console.ReadLine();
            //verbose way

            Console.WriteLine("This is what you typed in: " + userInput.ToLower());
        }
    }
}
using System;
namespace palindromecheck
{

    //program 2
    class Program
    {
        static void Main(string[] args)
        {

            string string1, rev;
            string1 = "Malayalam";
            char[] ch = string1.ToCharArray();

            Array.Reverse(ch);
            rev = new string(ch);

            bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("" + string1 + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + string1 + " is not a Palindrome!");
            }
            Console.Read();
        }
    }
}

using System;  
public class PalindromeExample
{
    public static void Main(string[] args)
    {
        int n, r, sum = 0, temp;
        Console.Write("Enter the Number: ");
        n = int.Parse(Console.ReadLine());
        temp = n;
        while (n > 0)
        {
            r = n % 10;
            sum = (sum * 10) + r;
            n = n / 10;
        }
        if (temp == sum)
            Console.Write("Number is Palindrome.");
        else
            Console.Write("Number is not Palindrome");
    }
}
*/
