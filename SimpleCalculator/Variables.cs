﻿using System;
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

        public Dictionary<string, int> VariablesList = new Dictionary<string, int>();

        public void VariableCreation(string input)
        {
            if (VariablePatternMath(input))
            {
                Match match = Regex.Match(input, pattern);
                Var = match.Groups["variable"].Value;
                Val = Convert.ToInt32(match.Groups["value"].Value);
                SetVariable(Var, Val);
            }
            else
            {
                throw new InputStringException("Input string is not valid.");
            }

        }

        public void SetVariable(string var, int val)
        {
            VariablesList.Add(var, val);
        }

        public bool CheckForVariableExpression(string input)
        {
            string pattern = @"^(?<term1>[a-zA-Z]?|[-]?[0-9]+)\s*(?<operation>[\+\-\/\*\%])\s*(?<term2>[a-zA-Z]?|[-]?[0-9]+)$";
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

        public string ConvertInputString(string input)
        {
            if (CheckForVariableExpression(input))
            {
                string pattern = @"^(?<term1>[a-zA-Z]?|[-]?[0-9]+)\s*(?<operation>[\+\-\/\*\%])\s*(?<term2>[a-zA-Z]?|[-]?[0-9]+)$";
                Match match = Regex.Match(input, pattern);
                string term1 = ConvertSingleTermIfContainedInDictionary(match.Groups["term1"].Value);
                string term2 = ConvertSingleTermIfContainedInDictionary(match.Groups["term2"].Value);
                return term1 + match.Groups["operation"].Value + term2;
            }
            else
            {
                return input;
            }
        }

        private string ConvertSingleTermIfContainedInDictionary(string term)
        {
            if (CheckDictionary(term))
            {
                return VariablesList[term].ToString();
            }
            else
            {
                return term;
            }
        }

        private bool CheckDictionary(string term)
        {
            if (VariablesList.ContainsKey(term))
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
