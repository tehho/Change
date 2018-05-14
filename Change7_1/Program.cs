using System;

using static System.Console;

namespace Change7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeMaker change = new ChangeMaker();

            var result = change.Change(50, 100);

            WriteLine($"Sum: {result.Item1} Count: {result.Item2}");

            WriteLine("Press any key to continue...");
            ReadKey();
        }
    }

}
