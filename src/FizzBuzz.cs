using System;

namespace src
{
    public class FizzBuzz
    {
        public string ReturnValue(int inputValue)
        {
            string responseString = "";
            if (inputValue % 3 == 0)
            {
                responseString += "Fizz";
            }
            if (inputValue % 5 == 0)
            {
                responseString += "Buzz";
            }
            if (responseString == "")
            {
                return inputValue.ToString();
            }
            return responseString;
        }
    }
}
