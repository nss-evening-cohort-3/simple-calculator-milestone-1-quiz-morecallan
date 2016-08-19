using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            int cycleCount = 0;
            Stack CurrentStack = new Stack();

            while (running)
            {
                Console.Write("[{0}]>", cycleCount);
                string userInput = Console.ReadLine();

                CalculatorCommands newCommand = new CalculatorCommands(userInput, CurrentStack);
                Console.WriteLine(newCommand.Output);
                cycleCount++;
            }
            Console.ReadKey();
        }
    }
}
