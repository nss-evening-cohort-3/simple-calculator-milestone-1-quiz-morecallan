using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorCommands
    {
        public CalculatorCommands(string input, Stack currentStack)
        {
            Output = OutputControl(input, currentStack);
        }

        public string OutputControl(string input, Stack current_stack)
        {
            
            switch (input)
            {
                case "last": return (current_stack.LastCommand != "") ? current_stack.LastCommand : "You've got no last command, dummy!";
                case "lastq": return (current_stack.LastAnswer != 0) ? current_stack.LastAnswer.ToString() : "You've got not last answer, dummy!";
                case "shut up": return "okay, bye.";
                default: Evaluate my_evaluate = new Evaluate(input); current_stack.setStack(input); return my_evaluate.Answer.ToString();
            }
        }

        public string Output { get; set; }
    }
}
