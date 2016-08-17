using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression
    {
        public void ParseStringIntoTermsAndOperation(string input)
        {
            string pattern = @"^(?<term1>[-]?[0-9]+)\s*(?<operation>[\+\-\/\*\%])\s*(?<term2>[-]?[0-9]+)$";
            Match match = Regex.Match(input, pattern);
            Term1 = Convert.ToInt32(match.Groups["term1"].Value);
            Term2 = Convert.ToInt32(match.Groups["term2"].Value);
        }
        public int Term1 { get; set; }
        public int Term2 { get; set; }
    }
}
