using System.Collections.Generic;
using Roughcut.Community.Core.Interfaces.Workflows;

namespace Roughcut.Community.Core.Models.Workflows
{
    public class RoughcutWorkflow : IRoughcutWorkflow
    {
        public List<RoughcutStep> Steps { get; set; }

        public RoughcutWorkflow()
        {
            this.Steps = new List<RoughcutStep>();
        }
    }
}
