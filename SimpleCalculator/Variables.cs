using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using SimpleCalculator.Exceptions;



namespace SimpleCalculator
{
    public class Variables
    {
        public string Var { get; set; }
        public int Val { get; set; }
        string pattern = @"^(?<variable>[a-z]{1})\s*\=\s*(?<value>\-?[0-9]+)$";

        public bool VariablePatternMath(string input)
        {
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        Dictionary<string, int> variables = new Dictionary<string, int>();

        public void VariableCreation (string input)
        {
            if (VariablePatternMath(input))
            {
                Match match = Regex.Match(input, pattern);
                Var = match.Groups["variable"].Value;
                Val = Convert.ToInt32(match.Groups["value"].Value);
            }
            else
            {
                throw new InputStringException("Input string is not valid.");
            }

        }

        public void SetVariable(string var, int val)
        {
            variables.Add(var, val);
        }
    }
}
