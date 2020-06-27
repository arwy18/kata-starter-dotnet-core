using System;
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
            else if(number.Length > 1)
            {
                var split_numbers = number.Split(",");
                return int.Parse(split_numbers[0]) + int.Parse(split_numbers[1]);
            }
            else
            {
                return int.Parse(number);    
            }
        }
    }
}