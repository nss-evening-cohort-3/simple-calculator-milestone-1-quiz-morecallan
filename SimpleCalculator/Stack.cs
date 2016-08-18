using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Stack
    {
        public void setStack(string validInput)
        {
            Evaluate stack_evaluate = new Evaluate(validInput);
            LastCommand = validInput;
            LastAnswer = stack_evaluate.Answer;
        }
        public string LastCommand { get; set; }
        public int LastAnswer { get; set; }
    }
}
