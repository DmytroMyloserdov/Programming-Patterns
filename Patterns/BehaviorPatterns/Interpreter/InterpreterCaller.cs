using System;
using System.Collections.Generic;

namespace Patterns.BehaviorPatterns.Interpreter
{
    public class InterpreterCaller
    {
        public static void Call()
        {
            var context = new Context();
            context.SetVariable("a", 2);
            context.SetVariable("b", 34);
            context.SetVariable("c", 234);
            context.SetVariable("d", 3);
            context.SetVariable("e", 97);

            var expression = new SubstructExpressions(
                new SubstructExpressions(
                    new AddExpressions(
                        new ExpressionToNumber("abc"), new ExpressionToNumber("a")
                    ),
                    new ExpressionToNumber("d")
                ),
                new ExpressionToNumber("ed")
            );

            List<int> res = expression.Interpret(context);
            res.ForEach(item => Console.Write(item));
        }
    }
}
