using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace SimpleCalculator
{
    public class Variables
    {
        string pattern = @"^(?<variable>[a-z]{1})\s*\=\s*(?<value>\-?[0-9]+)$";

        public bool variablePatternMath(string input)
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
    }
}
