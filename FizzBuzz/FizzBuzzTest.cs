using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int input = 1;

            string output = FizzBuzz.Value(input);

            Assert.AreEqual("1", output);
        }
    }
}