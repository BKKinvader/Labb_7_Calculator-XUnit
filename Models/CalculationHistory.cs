using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7_Calculator
{
    public class CalculationHistory
    {
        public List<string> CalculationList { get; private set; } = new List<string>();
        public void LogCalculation(decimal num1, decimal num2, char operation, decimal result)
        {
            string logEntry = $"Calculation: {num1} {operation} {num2} = {result}";
            CalculationList.Add(logEntry);
            Console.WriteLine(logEntry);
            //Console.ReadKey();
            //Console.Clear();
        }
        public void PrintCalculationHistory()
        {
            foreach (string calculation in CalculationList)
            {
                Console.WriteLine(calculation);
            }
        }
    }
}
