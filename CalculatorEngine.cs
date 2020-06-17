using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class CalculatorEngine
    {
        Input _inputFromUser = new Input();
        Calculate _calculateInput = new Calculate();

        private double input1;
        private double input2;
        private string operation;
        private double sum;

        public void CalculatorStart()
        {
            do
            {
                ApplicationTitle();
                TitleMenu();

                input1 = _inputFromUser.UserInputNumbers();
                input2 = _inputFromUser.UserInputNumbers();

                operation = _inputFromUser.UserInputOperation();

                sum = _calculateInput.CalculateInput(operation, input1, input2);

                Console.WriteLine($"\nThe sum of {input1} {operation} {input2} = {sum}");

            } while (_inputFromUser.AnotherCalcualtion());
        }

        private void ApplicationTitle()
        {
            Console.Title = "Basic Calculator";
        }

        private void TitleMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Basic Calculator");
            Console.ResetColor();
            Console.WriteLine(new string('*', 50));
        }

        
    }
}
