using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7_Calculator
{
    public class UserInput
    {
        public (decimal Number1, decimal Number2) Input(char option)
        {
            decimal num1, num2;

            do
            {
                Console.Write("Enter first number: ");
                num1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter second number: ");
                num2 = Convert.ToDecimal(Console.ReadLine());

                if (option == '/' && (num1 == 0 || num2 == 0))
                {
                    Console.Clear();
                    Console.WriteLine("Neither number can be zero for division. Please try again.");
                }
                else
                {
                    break; // exit the loop if the input is valid
                }
            

            } while (true);

           

            return (num1, num2);
        }
    }
}
