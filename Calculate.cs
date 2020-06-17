using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Calculate
    {
        public double CalculateInput(string operation, double input1, double input2)
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
