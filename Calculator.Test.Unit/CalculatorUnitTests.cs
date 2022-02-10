using System;
using Calculator;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        //Opgave 1: Test
        [TestCase(0, 5, 0)]
        [TestCase(5, 5, 1)]
        [TestCase(100.5, 5, 20.1)]
        [TestCase(-5, 5, -1)]
        [TestCase(-5, -5, 1)]
        [TestCase(10, 0.5, 20)]

        public void Divide_DivideNumbers_ResultIsCorrect(double a, double b, double result)
        //b !=0
        {
            Assert.That(_uut.DivideTwoParam(a, b), Is.EqualTo(result));
        }

        //Opgave 1.1

        [Test]
        public void Divide_DivideByZero_ResultIsException()
            //b =0
        {
            Assert.That(()=> _uut.Divide(5,0),Throws.TypeOf<DivideByZeroException>());
        }


        //Opgave 4: Test om Add-metoden i Calculator returnerer korrekt værdi
        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        [TestCase(3, 0, 3)]
        public void Add_PosAndNegNumbersToAccumulatorValue_ResultIsCorrect(double accumulator, double addend, double result)
        {
            _uut.Accumulator = accumulator;
            Assert.That(_uut.Add(addend), Is.EqualTo(result));
        }


        //Opgave 4: Test om Add-metoden i Calculator ændrer værdien af Accumulator
        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        [TestCase(3, 0, 3)]
        public void Add_PosAndNegNumbersToAccumulatorValue_AccumulatorChanges(double accumulator, double addend, double result)
        {
            _uut.Accumulator = accumulator;
            _uut.Add(addend);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }


        //Opgave 4: Test om Subtract-metoden i Calculator returnerer korrekt værdi
        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        public void Subtract_PosAndNegNumbersFromAccumulatorValue_ResultIsCorrect(double accumulator, double subtractor, double result)
        {
            _uut.Accumulator = accumulator;
            Assert.That(_uut.Subtract(subtractor), Is.EqualTo(result));
        }


        //Opgave 4: Test om Subtract-metoden i Calculator ændrer værdien af Accumulator
        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        public void Subtract_PosAndNegNumbersFromAccumulatorValue_AccumulatorChanges(double accumulator, double subtractor, double result)
        {
            _uut.Accumulator = accumulator;
            _uut.Subtract(subtractor);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }


        //Opgave 4: Test om Multiply-metoden i Calculator returnerer korrekt værdi
        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_PosAndNegNumbersAndAccumulatorValue_ResultIsCorrect(double accumulator, double multiplier, double result)
        {
            _uut.Accumulator = accumulator;
            Assert.That(_uut.Multiply(multiplier), Is.EqualTo(result));
        }


        //Opgave 4: Test om Multiply-metoden i Calculator ændrer værdien af Accumulator
        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_PosAndNegNumbersAndAccumulatorValue_AccumulatorChanges(double accumulator, double multiplier, double result)
        {
            _uut.Accumulator = accumulator;
            _uut.Multiply(multiplier);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }


        //Opgave 4: Test om Power-metoden i Calculator returnerer korrekt værdi
        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]

        public void Power_RaiseNumbers_ResultIsCorrect(double accumulator, double exponent, double result)
        {
            _uut.Accumulator = accumulator;
            Assert.That(_uut.Power(exponent), Is.EqualTo(result));
        }


        //Opgave 4: Test om Power-metoden i Calculator ændrer værdien af Accumulator
        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
        public void Power_RaiseNumbers_AccumulatorChanges(double accumulator, double exponent, double result)
        {
            _uut.Accumulator = accumulator;
            _uut.Power(exponent);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }



        //Opgave 4: Test om Divide-metoden i Calculator returnerer korrekt værdi
        [TestCase(0, 5, 0)]
        [TestCase(5, 5, 1)]
        [TestCase(100.5, 5, 20.1)]
        [TestCase(-5, 5, -1)]
        [TestCase(-5, -5, 1)]
        [TestCase(10, 0.5, 20)]

        public void Divide_AccumulatorWithPosAndNegNumbers_ResultIsCorrect(double accumulator, double divisor, double result)
        // b !=0
        {
            _uut.Accumulator = accumulator;
            Assert.That(_uut.Divide(divisor), Is.EqualTo(result));
        }

        // Opgave 4: Test om Divide-metoden i Calculator ændrer værdien af Accumulator
        [TestCase(0, 5, 0)]
        [TestCase(5, 5, 1)]
        [TestCase(100.5, 5, 20.1)]
        [TestCase(-5, 5, -1)]
        [TestCase(-5, -5, 1)]
        [TestCase(10, 0.5, 20)]
        public void Divide_AccumulatorWithPosAndNegNumbers_AccumulatorChanges(double accumulator, double divisor, double result)
        // b != 0
        {
            _uut.Accumulator = accumulator;
            _uut.Divide(divisor);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }




        // Herunder ses tests af Calculator før ændringer.

        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        [TestCase(3, 0, 3)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.AddTwoParam(a, b), Is.EqualTo(result));
        }

        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.SubtractTwoParam(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }


        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
        [TestCase(9, 0.5, 3.0)]
        public void PowerTwoParam_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        {
            Assert.That(_uut.PowerTwoParam(x, exp), Is.EqualTo(result));
        }

    }
}
