
using ConsoleApp1;

namespace FizzBuzzConsole
{
    public class FizzBuzzer
    {
        private ILogger _logger;

        public FizzBuzzer(ILogger logger)
        {
            _logger = logger;
        }

        public string Get(int v)
        {
            _logger.Log(v.ToString());
            if (v % 15 == 0)
                return "FizzBuzz";
            if (v % 5 ==0)
                return "Buzz";
            if (v % 3 == 0)
                return "Fizz";
            return v.ToString();
        }
    }
}