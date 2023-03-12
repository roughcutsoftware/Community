using Roughcut.Community.Core.Interfaces.Workflows;
using System.Collections.Generic;

namespace Roughcut.Community.Core.Models.Workflows
{
    public class RoughcutStep : IRoughcutStep
    {
        public List<RoughcutTask> Tasks { get; set; }

        public RoughcutStep()
        {
            this.Tasks = new List<RoughcutTask>();
        }
    }
}
