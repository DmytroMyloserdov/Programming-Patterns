using System.Collections.Generic;

namespace Patterns.BehaviorPatterns.Interpreter
{
    internal class ExpressionToNumber : IExpression
    {
        private string _input;

        public ExpressionToNumber(string input)
        {
            _input = input;
        }

        public List<int> Interpret(Context context)
        {
            List<int> res = new List<int>();
            foreach (var s in _input)
            {
                res.Add(context.GetVariable(s.ToString()));
            }

            return res;
        }

        public void ChangeInput(string newInput)
        {
            _input = newInput;
        }
    }
}
