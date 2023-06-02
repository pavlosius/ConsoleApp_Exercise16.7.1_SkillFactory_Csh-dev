using NUnit.Framework;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.That(calculator.Additional(300, 10) == 310);
        }
        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.That(calculator.Subtraction(300, 10) == 290);
        }
        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.That(calculator.Miltiplication(300, 10) == 3000);
        }
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(300, 10) == 30);
        }


    }
}
