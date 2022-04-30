using System;

namespace SyntaxExercise 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = 9;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine"; 

            Console.WriteLine(response);

        }
    }
}