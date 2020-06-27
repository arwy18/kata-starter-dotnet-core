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

            var separator = new string[]{",", "\n"};
            var input = number;
            if (number.StartsWith("//"))
            {
                var parts = number.Split("\n");
                input = parts[1];
                separator = new string[]{parts[0].Replace("//","")};
            }
            
            var numbers = input.Split(separator, StringSplitOptions.None).Select(int.Parse);
            return numbers.Sum();
        }
    }
}