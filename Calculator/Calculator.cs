using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Calculator
{
    public class Calculator
    {
        public double Accumulator { get; set; }



        public double Add(double addend)
        {
            Accumulator += addend; 
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            Accumulator -= subtractor;
            return Accumulator;
        }

        public double Multiply(double multiplier)
        {
            Accumulator *= multiplier;
            return Accumulator;
        }

        public double Power(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("invalid number in b");
            }
            return a / b;
        }
    }
}
