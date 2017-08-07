using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Number_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorOperation c = new CalculatorOperation();
            int n = c.Add("//;\n1;-2");
        }
    }
}
