﻿using System;

namespace string_interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mark";
            string world = " World";

            // composite formatting - position based
            Console.WriteLine("Hello, {0}!", name);                 // Hello, Mark!

            // composite formatting - position based
            var date = DateTime.Now;
            Console.WriteLine("Today is {0}", date.DayOfWeek);      // Today is Friday
            Console.WriteLine("it's {0:HH:mm} now.", date);         // it's 17:57 now.

            // composite formatting - position based
            Console.WriteLine("Hello, {0} {1}!", name, world);      // Hello, Mark  world!

            // string interpolation
            Console.WriteLine($"Hello, {name} {world}!");           // Hello, Mark  world!
        }
    }
}