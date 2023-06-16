using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7_Calculator
{
    public class Calculator
    {
        public CalculationHistory Log { get; } = new CalculationHistory();  // Expose CalculationHistory
        public decimal Result { get; private set; }

        public decimal Addition(decimal num1, decimal num2)
        {
            Result = num1 + num2;
            Result = Math.Round(Result, 2);
            Log.LogCalculation(num1, num2, '+', Result);
            return Result;
        }

        public decimal Subtraction(decimal num1, decimal num2)
        {
            Result = num1 - num2;
            Result = Math.Round(Result, 2);
            Log.LogCalculation(num1, num2, '-', Result);
            return Result;
        }

        public decimal Division(decimal num1, decimal num2)
        {
            Result = num1 / num2;
            Result = Math.Round(Result, 2);
            Log.LogCalculation(num1, num2, '/', Result);
            return Result;
        }
        public decimal Multiplication(decimal num1, decimal num2)
        {
            Result = num1 * num2;
            Result = Math.Round(Result, 2);
            Log.LogCalculation(num1, num2, '*', Result);
            return Result;
        }

    }
}
