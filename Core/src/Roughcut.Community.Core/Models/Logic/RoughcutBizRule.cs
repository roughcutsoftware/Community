using System;
using System.Linq.Expressions;
using Roughcut.Community.Core.Interfaces.Logic;

namespace Roughcut.Community.Core.Models.Logic
{
    public class RoughcutBizRule : IRoughcutBizRule
    {
        public RoughcutBizRule()
        {
            
        }

        public bool IsTrue()
        {
            Expression<Func<bool>> isTrue = () => 1 >= 2;
            var func = isTrue.Compile(); // Create Delegate
            var answer = func(); // Invoke Delegate

            //var one = Expression.Constant(1, typeof(int));
            //var two = Expression.Constant(2, typeof(int));
            //var addition = Expression.IsTrue(one, two);

            return answer;
        }
    }
}
