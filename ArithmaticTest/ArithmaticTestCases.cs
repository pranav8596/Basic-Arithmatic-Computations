using NUnit.Framework;
using ArithmaticOperations;

namespace ArithmaticTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        ArithmaticComputation arithmatic = new ArithmaticComputation();

        //Test case for addition of two integers
        [Test]
        public void givenTwoIntegers_WhenAdded_ShouldReturnItsResult()
        {
            int numberOne = 5;
            int numberTwo = 4;
            int addResult = arithmatic.addition(numberOne, numberTwo);
            Assert.AreEqual(9, addResult);
        }

        //Test case for subtraction of two integers
        [Test]
        public void givenTwoIntegers_WhenSubtracted_ShouldReturnItsResult()
        {
            int numberOne = 4;
            int numberTwo = 2;
            int subResult = arithmatic.subtraction(numberOne, numberTwo);
            Assert.AreEqual(2, subResult);
        }

        //Test case for multiplication of two integers
        [Test]
        public void givenTwoIntegers_WhenMultiplied_ShouldReturnItsResult()
        {
            int numberOne = 7;
            int numberTwo = 3;
            int mulResult = arithmatic.multiplication(numberOne, numberTwo);
            Assert.AreEqual(21, mulResult);
        }

        //Test case for division of two integers
        [Test]
        public void givenTwoIntegers_WhenDivided_ShouldReturnItsResult()
        {
            int numberOne = 6;
            int numberTwo = 2;
            int divResult = arithmatic.division(numberOne, numberTwo);
            Assert.AreEqual(3, divResult);
        }
    }
}