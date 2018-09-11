using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.BehaviorPatterns.Interpreter
{
    internal class AddExpressions : IExpression
    {
        IExpression _left;
        IExpression _right;

        public AddExpressions(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public IEnumerable<int> Interpret(Context context)
        {
            List<int> left = _left.Interpret(context).ToList();
            List<int> right = _right.Interpret(context).ToList();

            var isLeftBigger = left.Count > right.Count;
            int maxCount = 0, minCount = 0;


            if (left.Count > right.Count)
            {
                maxCount = left.Count;
                minCount = right.Count;

                for (int i = 0; i < (maxCount - minCount); i++)
                {
                    yield return left[i];
                }
                for (int i = 0; i < minCount; i++)
                {
                    yield return left[i + (maxCount - minCount)] + right[i];
                }
            }
            else
            {
                maxCount = right.Count;
                minCount = left.Count;

                for (int i = 0; i < (maxCount - minCount); i++)
                {
                    yield return right[i];
                }
                for (int i = 0; i < minCount; i++)
                {
                    yield return right[i + (maxCount - minCount)] - left[i];
                }
            }
        }

        public void ChangeExpressions(IExpression newLeft = null, IExpression newRight = null)
        {
            if (newLeft == null && newRight == null)
            {
                throw new ArgumentNullException("newLeft and newRight", "Both of arguments cant be null");
            }

            _left = newLeft ?? _left;
            _right = newRight ?? _right;
        }
    }
}
