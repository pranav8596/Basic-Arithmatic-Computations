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

        [Test]
        public void givenTwoIntegers_WhenAdded_ShouldReturnItsResult()
        {
            ArithmaticComputation arithmatic = new ArithmaticComputation();
            int numberOne = 4;
            int numberTwo = 2;
            int result = arithmatic.addition(numberOne, numberTwo);
            Assert.AreEqual(6, result);
        }
    }
}