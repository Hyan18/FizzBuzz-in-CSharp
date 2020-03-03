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
        public void Return_Itself_When_Given_Number_Not_Divisible_By_3_Or_5(
            [Values(1, 2, 4, 7, 8)] int input)
        {
            string output = FizzBuzz.Value(input);

            Assert.AreEqual(input.ToString(), output);
        }


        [Test]
        public void Return_Fizz_When_Given_Multiple_Of_3(
            [Values(3, 6, 9)] int input)
        {
            string output = FizzBuzz.Value(input);

            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Return_Buzz_When_Given_Multiple_Of_5(
            [Values(5, 10, 20)] int input)
        {
            string output = FizzBuzz.Value(input);

            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Return_FizzBuzz_When_Given_Multiple_Of_15(
            [Values(15, 30, 45)] int input)
        {
            string output = FizzBuzz.Value(input);

            Assert.AreEqual("FizzBuzz", output);
        }
    }
}