using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            var numbers = new List<int>();
            string str = "";

            // Make a foreach loop to iterate through your character array
            foreach (char c in arr)
            {
                try
                {
                    int num = int.Parse(c.ToString());
                    numbers.Add(num);
                }
                catch (Exception)
                {
                    Console.WriteLine($"Unable to Parse '{c}'");
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(str);
        }
    }
}
