using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create a string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------



            //TODO START HERE:
            var arr = new char[] {'9', '7', '5', '3', '1', '6', 'o', 'l', 'e'};
            var numbers = new List<int>();

            //string str = "";

            foreach (var item in arr)
            {                
                try
                {                    
                    numbers.Add(int.Parse(item.ToString()));

                }
                catch (Exception err)
                {
                
                    Console.WriteLine($"Unable to Parse '{item}'");
                    Console.WriteLine(err.Message);
                
                }
            }
                   
                                    

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
