using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// String array example
/// </summary>
namespace arraysExample1
{
    class BLessonExample2
    {

        public void Start()
        {

        }


        public static string[] CreateStringArray()
        {

            string[] strings = new string[50];
            strings[20] = "something cool";
            strings[60] = "does this work";

            return strings;

        }
    }
}
