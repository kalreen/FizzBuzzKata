using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string PrintFizzBuzz(int input)
        {
           if (input == 3)
            {
                return "Fizz";
            }
            return input.ToString();
        }
    }
}
