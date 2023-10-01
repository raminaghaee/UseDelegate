using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Calculator
    {
        public delegate int CalculatorDelegate(int x, int y);
        public void Equal(int x, int y, char operatorChar)
        {
            if (operatorChar == '+' || operatorChar == '-' || operatorChar == '*' || operatorChar == '/')
            {

                CalculatorDelegate calculator = operatorChar switch
                {
                    '+' => calculator = Sum,
                    '-' => calculator = Subtraction,
                    '*' => calculator = Multiplication,
                    '/' => calculator = Division,
                };
                Console.WriteLine(calculator(x, y));
            }
            else
                Console.WriteLine("Error performing the operation, try again");
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Subtraction(int x, int y)
        {
            return x - y;
        }
        public static int Multiplication(int x, int y)
        {
            return x * y;
        }
        public static int Division(int x, int y)
        {
            return x / y;
        }
    }
}
