using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7_Calculator
{
    public class HomeMenu
    {
        public void Menu()
        {
            bool isRunning = true;
            Calculator calculator = new Calculator();
            CalculationHistory history = calculator.Log; // Use the CalculationHistory from Calculator
            UserInput input = new UserInput();
            

            do
            {
                (decimal Number1, decimal Number2) inputNumbers;




                Console.WriteLine("Choose calculation method you want ?\n" +

                    "1. Addition\n" +
                    "2. Substraction\n" +
                    "3. Division\n" +
                    "4. Multiplication\n" +
                    "5. View Calculation History\n" +
                    "6. Order66");

                int inputMenu;

                if (!int.TryParse(Console.ReadLine(), out inputMenu))
                {
                    Console.WriteLine("Invalid input, please enter a number from 1 to 6.");
                    continue;
                }
                Console.Clear();

                switch (inputMenu)
                {
                    case 1:
                        Console.WriteLine("Addition");
                        inputNumbers = input.Input('+');
                        calculator.Addition(inputNumbers.Number1, inputNumbers.Number2);
                        
                        break;
                        
                    case 2:
                        Console.WriteLine("Subtraction");
                        inputNumbers = input.Input('-');                       
                        calculator.Subtraction(inputNumbers.Number1, inputNumbers.Number2);
                        
                        break;

                    case 3:
                        
                        Console.WriteLine("Division");
                        inputNumbers = input.Input('/');
                        calculator.Division(inputNumbers.Number1, inputNumbers.Number2);
                       
                        break;

                    case 4:

                        Console.WriteLine("Multiplication");
                        inputNumbers = input.Input('*');
                        calculator.Multiplication(inputNumbers.Number1, inputNumbers.Number2);

                        
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Calculation History");
                        history.PrintCalculationHistory();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;



                }


            } while (isRunning);


        }
    }
}
