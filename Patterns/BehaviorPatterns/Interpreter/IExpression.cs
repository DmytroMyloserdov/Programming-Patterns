using System.Collections.Generic;

namespace Patterns.BehaviorPatterns.Interpreter
{
    public interface IExpression
    {
        List<int> Interpret(Context context);
    }
}
