using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    internal class MathProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Math Class ---\n");

            // 1. Math.Abs()
            int negativeNumber = -25;
            int absoluteResult = Math.Abs(negativeNumber);
            Console.WriteLine($"1. Absolute value of {negativeNumber} is: {absoluteResult}");

            // 2. Math.Pow()
            double baseNumber = 5;
            double exponent = 2;
            double powerResult = Math.Pow(baseNumber, exponent);
            Console.WriteLine($"2. {baseNumber} raised to the power of {exponent} is: {powerResult}");

            Console.ReadLine();
        }
    }
}