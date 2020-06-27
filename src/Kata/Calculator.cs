using System;
using System.Linq;
using System.Runtime.Serialization;

namespace Kata
{
    public class Calculator
    {
        public int Add(string number = "")
        {
            if (string.IsNullOrEmpty(number))
            {
                return 0;                
            }

            var numbers = number.Split(",").Select(int.Parse);
            return numbers.Sum();
        }
    }
}