using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string Value(int input)
        {
            if (input == 3)
                return "Fizz";
            return input.ToString();
        }
    }
}
