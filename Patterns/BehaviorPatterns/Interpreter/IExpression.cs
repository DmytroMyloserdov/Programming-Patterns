using System.Collections.Generic;

namespace Patterns.BehaviorPatterns.Interpreter
{
    public interface IExpression
    {
        IEnumerable<int> Interpret(Context context);
    }
}
