using NUnit.Framework;
using FunctionBuilder.Logic;

namespace FunctionBuilder.Tests
{

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase("|1,5 * (1 + 6)|", ExpectedResult = "10,5")]
        public string Calculator_Test(string expression)
        {
            return new Calculator(expression).Answer.ToString();
        }
    }
}