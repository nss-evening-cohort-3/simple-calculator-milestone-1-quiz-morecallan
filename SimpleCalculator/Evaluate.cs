using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluate
    {
        public void Evaluation(string input, Variables currentVariables)
        {
            Expression expressionToEvaluate = new Expression();
            if (currentVariables.VariablePatternMath(input))
            {
                currentVariables.VariableCreation(input);
                
                Answer = String.Format("Saved '{0}' as '{1}'", currentVariables.Var, currentVariables.Val);
            }
            else if (currentVariables.CheckDictionary(input.ToLower()))
            {
                input = input.ToLower();
                Answer = currentVariables.VariablesList[input].ToString();
            }
            else
            {
                string convertedForVariables = currentVariables.ConvertInputString(input);
                try
                {
                    expressionToEvaluate.ParseStringIntoTermsAndOperation(convertedForVariables);
                    Answer = OperationParser(expressionToEvaluate.Term1, expressionToEvaluate.Term2, expressionToEvaluate.Operation).ToString();
                }
                catch
                {
                    CalculatorCommands commandOutput = new CalculatorCommands();
                    Answer = "Oopsie Daisy. Please enter a valid command.";
                }
            }
        }

        public int OperationParser(int term1, int term2, string operation)
        {
            switch (operation)
            {
                case "+": return term1 + term2;
                case "-": return term1 - term2;
                case "*": return term1 * term2;
                case "/": return term1 / term2;
                case "%": return term1 % term2;
                default: return 0;
            }
        }

        public string Answer { get; set; }
    }
}
