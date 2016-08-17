using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SimpleCalculator.Exceptions;

namespace SimpleCalculator
{
    public class Expression
    {
        private bool checkForValidString(string input)
        {
            string pattern = @"^(?<term1>[-]?[0-9]+)\s*(?<operation>[\+\-\/\*\%])\s*(?<term2>[-]?[0-9]+)$";
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void ParseStringIntoTermsAndOperation(string input)
        {
            if (checkForValidString(input))
            {
                string pattern = @"^(?<term1>[-]?[0-9]+)\s*(?<operation>[\+\-\/\*\%])\s*(?<term2>[-]?[0-9]+)$";
                Match match = Regex.Match(input, pattern);
                Term1 = Convert.ToInt32(match.Groups["term1"].Value);
                Term2 = Convert.ToInt32(match.Groups["term2"].Value);
                Operation = match.Groups["operation"].Value;
            }
            else
            {
                throw new InputStringException("Input string is not valid.");
            }
            
        }

        public int Term1 { get; set; }
        public int Term2 { get; set; }

        public string Operation { get; set;}
    }
}
