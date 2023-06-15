using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Tasks
//In this task, you have to complete the method “Calculate”. This method takes 3 unsigned integers “numerator” and “denominator” and another “length”. You have to print the fraction value up to the provided length after the decimal point. For example, if the numerator is 22 and denominator is 7 and length is 11, then the return value will be a string “3.14159265359”. [Score: 50]

namespace Task1
{
    public class LongDecimal
    {
        public string Calculate(uint numerator, uint denominator, uint length)
        {
            float divide = (float) numerator / denominator;
            string fractionValue = divide.ToString($"F{length}");
            return fractionValue;
        }
    }
}
