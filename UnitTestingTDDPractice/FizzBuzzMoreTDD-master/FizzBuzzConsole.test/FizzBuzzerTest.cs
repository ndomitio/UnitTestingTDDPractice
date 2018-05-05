using NUnit.Framework;
using NSubstitute;
using ConsoleApp1;

namespace FizzBuzzConsole.test
{
    [TestFixture]  ///this is a container for tests we are going to write now
    public class FizzBuzzerTest
    {
        //[Test]
        //public void Get_Returns_1_for_1()
        //{
        //    var fizzBuzzer = new FizzBuzzer();
        //    var result = fizzBuzzer.Get(1);
        //    Assert.That(result, Is.EqualTo("1"));

        //}
        //[Test]
        //public void Get_Returns_2_for_2()
        //{
        //    var fizzBuzzer = new FizzBuzzer();
        //    var result = fizzBuzzer.Get(2);
        //    Assert.That(result, Is.EqualTo("2"));

        //}
        //[Test]
        //public void Get_Returns_Fizz_for_3()
        //{
        //    var fizzBuzzer = new FizzBuzzer();
        //    var result = fizzBuzzer.Get(3);
        //    Assert.That(result, Is.EqualTo("Fizz"));

        //}
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        public void Get_Returns_Expected_Value(int input, string expected)
        {
            //var sqlLogger = new SqlDatabaseLogger();
            var fizzBuzzer = new FizzBuzzer(/*sqlLogger*/);
            var result = fizzBuzzer.Get(input);
            //System.Console.WriteLine("foo " + input.ToString());
            Assert.That(result, Is.EqualTo(expected));
        }

        //[Test]
        ////public void Get_Logs_The_Number()
        //{
        //    // NSubstitute
        //    ILogger logger = Substitute.For<ILogger>();
        //    var fizzBuzzer = new FizzBuzzer(logger);
        //    fizzBuzzer.Get(42);

        //    logger.Received().Log("43");
        //}

    } }
