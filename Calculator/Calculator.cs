using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Calculator
{
    public class Calculator
    {
        public double Accumulator { get; set; }

        //metode med to parametre
        public double AddTwoParam(double a, double b)
        {
            return a + b;
        }

        //Metoden lægger "addend" sammen med "Accumulator".
        //Resultatet gemmes i Accumulator og returneres.
        public double Add(double addend)
        {
            Accumulator += addend; 
            return Accumulator;
        }

        //metode med to parametre
        public double SubtractTwoParam(double a, double b)
        {
            return a - b;
        }
        //Metoden trækker "subtractor" fra "Accumulator".
        //Resultatet gemmes i Accumulator og returneres.
        public double Subtract(double subtractor)
        {
            Accumulator -= subtractor;
            return Accumulator;
        }

        //metode med to parametre
        public double Multiply(double a, double b)
        {
            return a *b;
        }
        //Metoden ganger "multiplier" med "Accumulator".
        //Resultatet gemmes i Accumulator og returneres.
        public double Multiply(double multiplier)
        {
            Accumulator *= multiplier;
            return Accumulator;
        }


        //metode med to parametre
        public double PowerTwoParam(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        //Metoden opløfter "Accumulator" i "exponent"
        //Resultatet gemmes i Accumulator og returneres.
        public double Power(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }


        //Opgave 1
        public double DivideTwoParam(double a, double b)
        {
            if (b == 0)
            {
              throw new DivideByZeroException("invalid number in parameter b");

            }
            return a / b;
        }

      //  Opgave 4 - Ændret version af ovenstående metode(fra opgave 1). 
        public double Divide(double divisor)
        {
            if (divisor == 0)
            {
                Console.WriteLine("invalid number in divisor");
            }
            return Accumulator /= divisor;
        }
    }
}
