using System.Collections.Specialized;
using System.Text;
using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //date 1-8
            DateTime today = DateTime.Now;
            System.Console.WriteLine($"1.{today:MMMM} {today:dd}, {today:yyyy}");
            System.Console.WriteLine($"2.{today:yyyy}.{today:MM}.{today:dd}");
            System.Console.WriteLine($"3.Day {today:dd} of {today:MMMM}, {today:yyyy}");
            System.Console.WriteLine($"4.Year:{today:yyyy}, Month:{today:MM}, Day:{today:dd}");
            System.Console.WriteLine($"5.{"",10}{today:dddd}(10 spaces)");
            System.Console.WriteLine($"6.{today:t}{"",13}{today:dddd}(3 spaces before, 10 spaces between)");
            System.Console.WriteLine($"7.h{today:HH} ,m:{today:mm}, s:{today:ss}");
            System.Console.WriteLine($"{today:yyyy}.{today:MM}.{today:dd}.{today:HH}.{today:mm}.{today:ss}");
            
            //pi stuff
            Console.WriteLine("\nPI Stuff");
            System.Console.WriteLine($"1. {Math.PI:C}");
            System.Console.WriteLine($"2.{null,10}{Math.PI:0.000}");
        }
    }
}
