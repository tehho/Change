﻿
using static System.Console;

namespace Change
{
    class Program
    {
        static void Main(string[] args)
        {
            var change = new ChangeMaker_Tuple();

            var result = change.Change(50, 100);

            WriteLine($"Sum: {result.Item1} Count: {result.Item2}");

            WriteLine("Press any key to continue...");
            ReadKey();

        }


    }
}
