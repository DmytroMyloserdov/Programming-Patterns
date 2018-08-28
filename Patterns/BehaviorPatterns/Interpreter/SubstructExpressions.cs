using System;
using System.Collections.Generic;

namespace Patterns.BehaviorPatterns.Interpreter
{
    public class SubstructExpressions : IExpression
    {
        IExpression _left;
        IExpression _right;

        public SubstructExpressions(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public List<int> Interpret(Context context)
        {
            List<int> left = _left.Interpret(context) as List<int>;
            List<int> right = _right.Interpret(context) as List<int>;
            List<int> res = new List<int>();

            var isLeftBigger = left.Count > right.Count;
            int maxCount = 0, minCount = 0;


            if (isLeftBigger)
            {
                maxCount = left.Count;
                minCount = right.Count;

                for (int i = 0; i < (maxCount - minCount); i++)
                {
                    res.Add(left[i]);
                }
                for (int i = 0; i < minCount; i++)
                {
                    res.Add(left[i + (maxCount - minCount)] - right[i]);
                }
            }
            else
            {
                maxCount = right.Count;
                minCount = left.Count;

                for (int i = 0; i < (maxCount - minCount); i++)
                {
                    res.Add(-right[i]);
                }
                for (int i = 0; i < minCount; i++)
                {
                    res.Add(right[i + (maxCount - minCount)] - left[i]);
                }
            }

            return res;
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
