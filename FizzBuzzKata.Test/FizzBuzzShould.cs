namespace FizzBuzzKata.Test
{
    public class FizzBuzzShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1,"1")]
        [TestCase(2,"2")]
        [TestCase(4, "4")]
        public void Return_number_as_string(int input, string output)
        {
            var result = FizzBuzz.Print(input);
            Assert.AreEqual(output, result);
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void return_Fizz_for_multiples_of_three(int input)
        {
            var result = FizzBuzz.Print(input);
            Assert.AreEqual("Fizz", result);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void return_Buzz_for_multiples_of_five(int input)
        {
            var result = FizzBuzz.Print(input);
            Assert.AreEqual("Buzz", result);
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void return_FizzBuzz_for_multiples_of_three_and_five(int input)
        {
            var result = FizzBuzz.Print(input);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
    }
}