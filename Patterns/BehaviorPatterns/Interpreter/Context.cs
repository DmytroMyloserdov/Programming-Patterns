using System.Collections.Generic;

namespace Patterns.BehaviorPatterns.Interpreter
{
    public class Context
    {
        Dictionary<string, int> variables;

        public Context()
        {
            variables = new Dictionary<string, int>();
        }

        public void SetVariable(string symbol, int value)
        {
            if (variables.ContainsKey(symbol))
            {
                variables.Add(symbol, value);
            }
            else
            {
                variables[symbol] = value;
            }
        }

        public int GetVariable(string symbol)
        {
            return variables[symbol];
        }
    }
}
