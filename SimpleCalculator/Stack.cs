using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Stack
    {
        public void setStack(string validInput, string answer)
        {
            LastCommand = validInput;
            LastAnswer = answer;
        }
        public string LastCommand { get; set; }
        public string LastAnswer { get; set; }
    }
}
