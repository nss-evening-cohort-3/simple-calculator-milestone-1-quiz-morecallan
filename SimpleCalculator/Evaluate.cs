using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluate
    {
        public Evaluate(string input)
        {
            Expression expressionToEvaluate = new Expression();
            expressionToEvaluate.ParseStringIntoTermsAndOperation(input);
            Answer = OperationParser(expressionToEvaluate.Term1, expressionToEvaluate.Term2, expressionToEvaluate.Operation);
        }

        public int OperationParser(int term1, int term2, string operation)
        {
            switch (operation)
            {
                case "+": return term1 + term2;
                case "-": return term1 - term2;
                case "/": return term1 / term2;
                case "*": return term1 * term2;
                case "%": return term1 % term2;
                default: return 0;
            }
        }

        public int Answer { get; set; }
    }
}
