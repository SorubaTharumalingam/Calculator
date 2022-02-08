using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Calculator
{
    public class Calculator
    {
        public double Accumulator { get; set; }

        //Metoden lægger "addend" sammen med "Accumulator".
        //Resultatet gemmes i Accumulator og returneres.
        public double Add(double addend)
        {
            Accumulator += addend;
            return Accumulator;
        }

        //Metoden trækker "subtractor" fra "Accumulator".
        //Resultatet gemmes i Accumulator og returneres.
        public double Subtract(double subtractor)
        {
            Accumulator -= subtractor;
            return Accumulator;
        }

        //Metoden ganger "multiplier" med "Accumulator".
        //Resultatet gemmes i Accumulator og returneres.
        public double Multiply(double multiplier)
        {
            Accumulator *= multiplier;
            return Accumulator;
        }

        //Metoden opløfter "Accumulator" i "exponent"
        //Resultatet gemmes i Accumulator og returneres.
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
