using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'A', 'B', 'C' };
            var numbers = new List<int>();
            var str = "";
            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            
            // Make a foreach loop to iterate through your character array
            foreach(var item in arr)
            {
                try
                {
                    str = item.ToString();
                    var number = int.Parse(str);
                    numbers.Add(number);
                } catch(Exception e)
                {
                    Console.WriteLine($"Unable to Parse '{item}'");
                }
            }
                
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
