using NUnit.Framework;

namespace FizzBuzz
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

        [Test]
        public void Return_Fizz_When_Given_3()
        {
            int input = 3;

            string output = FizzBuzz.Value(input);

            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Return_Fizz_When_Given_6()
        {
            int input = 6;

            string output = FizzBuzz.Value(input);

            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Return_Buzz_When_Given_5()
        {
            int input = 5;

            string output = FizzBuzz.Value(input);

            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Return_Buzz_When_Given_10()
        {
            int input = 10;

            string output = FizzBuzz.Value(input);

            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Return_FizzBuzz_When_Given_15()
        {
            int input = 15;

            string output = FizzBuzz.Value(input);

            Assert.AreEqual("FizzBuzz", output);
        }

        [Test]
        public void Return_FizzBuzz_When_Given_30()
        {
            int input = 30;

            string output = FizzBuzz.Value(input);

            Assert.AreEqual("FizzBuzz", output);
        }
    }
}