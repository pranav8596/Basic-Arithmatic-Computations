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
            int numberOne = 4;
            int numberTwo = 2;
            int addResult = arithmatic.addition(numberOne, numberTwo);
            Assert.AreEqual(6, addResult);
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
            int numberOne = 4;
            int numberTwo = 2;
            int mulResult = arithmatic.multiplication(numberOne, numberTwo);
            Assert.AreEqual(8, mulResult);
        }

    }
}