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
        public void Return_1_When_Given_1()
        {
            int input = 1;

            string output = FizzBuzz.Value(input);

            Assert.AreEqual("1", output);
        }

        [Test]
        public void Return_2_When_Given_2()
        {
            int input = 2;

            string output = FizzBuzz.Value(input);

            Assert.AreEqual("2", output);
        }
    }
}