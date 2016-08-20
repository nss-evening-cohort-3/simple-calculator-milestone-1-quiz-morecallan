using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorCommands
    {
        public CalculatorCommands()
        { }

        public CalculatorCommands(string input, Stack currentStack, Variables currentVariables)
        {
            Output = OutputControl(input, currentStack, currentVariables);
        }

        public string OutputControl(string input, Stack current_stack, Variables current_variables)
        {
            
            switch (input)
            {
                case "lastq": return (current_stack.LastCommand != "") ? current_stack.LastCommand : "You've got no last command, dummy!";
                case "last": return (current_stack.LastAnswer != "") ? current_stack.LastAnswer.ToString() : "You've got not last answer, dummy!";
                case "shut up": Environment.Exit(1);  return "okay, bye";
                default: Evaluate my_evaluate = new Evaluate(); my_evaluate.Evaluation(input, current_variables); current_stack.setStack(input, my_evaluate.Answer); return my_evaluate.Answer;
            }
        }

        public string Output { get; set; }
    }
}
