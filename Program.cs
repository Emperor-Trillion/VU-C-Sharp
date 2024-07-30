using System;
using System.Collections.Generic;

namespace TaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Maximum Number of the Fibonacci Sequence: ");
            int entry = Convert.ToInt32(Console.ReadLine());
            Fibonacci number = new();
            List<int> Table = number.GenerateSequence(entry);
            Fibonacci.PrintTable(Table);
            int MaxIteration = number.GetIterationCount();
            int MaxValue = number.GetMaxValue();
            Console.WriteLine("\nNumber of Iterations of this Sequence: " + MaxIteration);
            Console.WriteLine("Maximum Value of the Sequence: " + MaxValue);

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------");


            Console.Write("Enter the Lower Range: ");
            int lowerRange = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Upper Range: ");
            int upperRange = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nSequence in Range are: ");
            List<int> Result = number.GetArrayOfResults(lowerRange, upperRange);
            Fibonacci.PrintGrid(Result);
            Console.WriteLine("\nNumber of Iterations of this Range: " + (Result.Count - 1));
            Console.WriteLine("Maximum Value of the Range: " + Result[Result.Count - 1]);

            Console.ReadKey();
        }
    }

}