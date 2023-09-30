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
        public void equal(int x , int y,char operatorChar)
        {

            CalculatorDelegate calculator = operatorChar switch
            {
                '+' => calculator = Sum,
                '-' => calculator = Subtraction,
                '*' => calculator = Multiplication,
                '/' => calculator = Division,
                _ => calculator = Sum,
            };
            Console.WriteLine(calculator(x,y));
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
