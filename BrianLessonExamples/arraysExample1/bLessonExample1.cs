using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysExample1
{

    /// <summary>
    /// Integer array example
    /// </summary>
    class BLessonExample1
    {
        //this is a constructor
        public BLessonExample1()
        {

        }

        public void Start()
        {
            int[] nums = CreateIntArray();

            //  string[] strings = CreateStringArray();


            bool isFound = false;

            int numberToFind = 34;

            isFound = FindNumber(nums, numberToFind);

            Console.WriteLine(numberToFind + "found status: " + isFound);


        }



        public static int[] CreateIntArray()
        {
            int[] nums = new int[10];
            nums[0] = 5;
            nums[1] = 1;
            nums[2] = 3;
            nums[3] = 8;
            nums[4] = 22;
            nums[5] = 555;
            nums[6] = 0;
            nums[7] = 34;
            nums[8] = 99;
            nums[9] = 55;

            return nums;
        }

        public static bool FindNumber(int[] numbers, int numberToFind)
        {

            int arraySize = numbers.Length;
            bool isFound = false;

            for (int i = 0; i < arraySize; i++)
            {

                if (numbers[i] == numberToFind)
                {
                    isFound = true;
                    Console.WriteLine("Found it at element location: " + i);
                }
            }

            return isFound;
        }
    }
}
