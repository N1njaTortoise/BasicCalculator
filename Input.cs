using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BasicCalculator
{
    class Input
    {
        private int _tempPlaceHolderOfConverter;
        private string _tempPlaceHolderOfOperation;
        private string _tempStartAgain;

        public int TempPlaceHolderOfConverter
        {
            get { return _tempPlaceHolderOfConverter; }
        }

        public string TempPlaceHolderOfOperation
        {
            get { return _tempPlaceHolderOfOperation; }
        }

        public double UserInputNumbers()
        {
            while (true)
            {
                Console.Write("Enter a number: ");

                if (int.TryParse(Console.ReadLine(), out _tempPlaceHolderOfConverter))
                {
                    return _tempPlaceHolderOfConverter;
                }
                else
                {
                    ErrorMessage("number");

                    ClearSectionOfConsoleLines(2);
                }
            }
        }

        public string UserInputOperation()
        {
            while (true)
            {
                Console.Write("Enter the type of operation to do (+, -, *, /): ");
                _tempPlaceHolderOfOperation = Console.ReadLine();

                if (_tempPlaceHolderOfOperation == "+" || _tempPlaceHolderOfOperation == "-" || _tempPlaceHolderOfOperation == "*" || _tempPlaceHolderOfOperation == "/")
                {
                    return _tempPlaceHolderOfOperation;
                }
                else
                {
                    ErrorMessage("operation");

                    ClearSectionOfConsoleLines(2);
                }
            }
        }

        public bool AnotherCalcualtion()
        {
            while (true)
            {
                Console.Write("\nWould you like to calculate another basic arithmatic? (y/n): ");
                _tempStartAgain = Console.ReadLine();

                if (_tempStartAgain.ToLower().Equals("y"))
                {
                    Console.Clear();
                    return true;
                }
                else if (_tempStartAgain.ToLower().Equals("n"))
                {
                    Console.Clear();
                    return false;
                }
                else
                {
                    ErrorMessage("input");

                    ClearSectionOfConsoleLines(2);
                }
            }
        }

        private void ErrorMessage(string message)
        {
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Please enter a valid {message}.");
            Console.ResetColor();
            Thread.Sleep(2000);
        }

        private static void ClearSectionOfConsoleLines(int rows)
        {
            int currentCursorLine = Console.CursorTop - rows;

            for (int i = 1; i <= rows; i++)
            {
                Console.SetCursorPosition(0, Console.CursorTop - i);
                Console.Write(new string(' ', Console.WindowWidth));
            }
            Console.SetCursorPosition(0, currentCursorLine);
        }
    }
}
