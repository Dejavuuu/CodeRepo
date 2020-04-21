using System;

namespace WhatsMyName
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(vbCrLf + "What is your name? ")
           Dim name = Console.ReadLine()
           Dim currentDate = DateTime.Now
           Console.WriteLine($"{vbCrLf"}Hello, {name}, on {currentDate:t}")
           Console.Write(vbCrLf + Press any key to exit.... ")
           Console.ReadKey(true)
           End Sub
        }
    }
}
