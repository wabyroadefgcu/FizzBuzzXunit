using System;
using Xunit;

using src;

namespace tests
{
    public class FizzBuzzTests
    {
        private FizzBuzz _fizzBuzz = new FizzBuzz();

        [Fact]
        public void ItExists()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Fact]
        public void ItHasReturnValueMethod()
        {
            _fizzBuzz.ReturnValue(2);
        }

        [Fact]
        public void ReturnFizzOn3()
        {
            string response = _fizzBuzz.ReturnValue(3); 
            Assert.Equal("Fizz", response);
        }
    }
}
