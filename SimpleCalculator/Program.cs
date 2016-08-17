using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression my_expression = new Expression();
            my_expression.ParseStringIntoTermsAndOperation("1+2");
            Console.ReadKey();
        }
    }
}
