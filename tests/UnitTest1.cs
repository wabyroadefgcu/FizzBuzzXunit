﻿using System;
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
        //Given
            string response = _fizzBuzz.ReturnValue(3); 
        //Then
            Assert.Equal("Fizz", response);
        }

        [Fact]
        public void ReturnBuzzOn5()
        {
        //Given
            string response = _fizzBuzz.ReturnValue(5);
        //Then
            Assert.Equal("Buzz",response);
        }

        [Fact]
        public void ReturnNumberOn1()
        {
        //Given
            string response = _fizzBuzz.ReturnValue(1);
        //Then
            Assert.Equal("1",response);
        }

        [Fact]
        public void ReturnFizzBuzzOn15()
        {
        //Given
            string response = _fizzBuzz.ReturnValue(15);
        //Then
            Assert.Equal("FizzBuzz",response);
        }
    }
}
