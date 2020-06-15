using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class CalculatorEngine
    {
        private double input1;
        private double input2;
        private string operation;
        private double sum;

        public void CalculatorStart()
        {
            while (true)
            {
                UserInput();

                sum = Calculate();

                Console.WriteLine($"The sum of {input1}{operation}{input2}={sum}");
            }
        }

        private void UserInput()
        {
            Console.Write("Enter a number: ");
            input1 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            input2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the type of operation to do (+, -, *, /): ");
            operation = Console.ReadLine();


        }

        private double Calculate()
        {
            switch (operation)
            {
                case "+":
                    return input1 + input2;
                case "-":
                    return input1 - input2;
                case "*":
                    return input1 * input2;
                case "/":
                    return input1 / input2;
                default:
                    Console.WriteLine("The incorrect operation type was used.");
                    return 0;
            }
        }
    }
}
