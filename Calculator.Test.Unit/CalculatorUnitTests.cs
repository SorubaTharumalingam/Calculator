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

        //Herunder ses tests til opgave 4. 

        //Test om Add-metoden i Calculator returnerer korrekt værdi
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


        //Test om Add-metoden i Calculator ændrer værdien af Accumulator
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


        //Test om Subtract-metoden i Calculator returnerer korrekt værdi
        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        public void Subtract_PosAndNegNumbersFromAccumulatorValue_ResultIsCorrect(double accumulator, double subtractor, double result)
        {
            _uut.Accumulator = accumulator;
            Assert.That(_uut.Subtract(subtractor), Is.EqualTo(result));
        }


        //Test om Subtract-metoden i Calculator ændrer værdien af Accumulator
        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        public void Subtract_PosAndNegNumbersFromAccumulatorValue_AccumulatorChanges(double accumulator, double subtractor, double result)
        {
            _uut.Accumulator = accumulator;
            _uut.Subtract(subtractor);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }


        //Test om Multiply-metoden i Calculator returnerer korrekt værdi
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


        //Test om Multiply-metoden i Calculator ændrer værdien af Accumulator
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


        //Test om Power-metoden i Calculator returnerer korrekt værdi
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


        //Test om Power-metoden i Calculator ændrer værdien af Accumulator
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




        //Herunder ses tests af Calculator før ændringer.
        //[TestCase(3, 2, 5)]
        //[TestCase(-3, -2, -5)]
        //[TestCase(-3, 2, -1)]
        //[TestCase(3, -2, 1)]
        //[TestCase(3, 0, 3)]
        //public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        //{
        //    Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        //}

        //[TestCase(3, 2, 1)]
        //[TestCase(-3, -2, -1)]
        //[TestCase(-3, 2, -5)]
        //public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        //{
        //    Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        //}


        //[TestCase(3, 2, 6)]
        //[TestCase(-3, -2, 6)]
        //[TestCase(-3, 2, -6)]
        //[TestCase(3, -2, -6)]
        //[TestCase(0, -2, 0)]
        //[TestCase(-2, 0, 0)]
        //[TestCase(0, 0, 0)]
        //public void Multiply_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        //{
        //    Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        //}


        //[TestCase(2, 3, 8)]
        //[TestCase(2, -3, 0.125)]
        //[TestCase(-2, -3, -0.125)]
        //[TestCase(1, 10, 1)]
        //[TestCase(1, -10, 1)]
        //[TestCase(10, 0, 1)]
        // [TestCase(4, 0.5, 2.0)]
        //[TestCase(9, 0.5, 3.0)]
        //public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        //{
        //    Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        //}      
    }
}
