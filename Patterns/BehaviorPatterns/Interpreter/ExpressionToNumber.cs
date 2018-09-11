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

        public IEnumerable<int> Interpret(Context context)
        {
            foreach (var s in _input)
            {
                yield return context.GetVariable(s.ToString());
            }
        }

        public void ChangeInput(string newInput)
        {
            _input = newInput;
        }
    }
}
