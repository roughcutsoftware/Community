using Roughcut.Community.Core.Interfaces.Workflows;
using System.Collections.Generic;
using Roughcut.Community.Core.Models.Logic;

namespace Roughcut.Community.Core.Models.Workflows
{
    public class RoughcutTask : IRoughcutTask
    {
        public List<RoughcutBizRule> BizRules { get; set; }

        public RoughcutTask()
        {
            this.BizRules = new List<RoughcutBizRule>();
        }

        public bool IsValid()
        {
            bool isValid = true;

            foreach (RoughcutBizRule bizRule in BizRules)
            {
                if (!bizRule.IsTrue())
                {
                    isValid = false;

                }
            }

            //
            return isValid;
        }
    }
}
