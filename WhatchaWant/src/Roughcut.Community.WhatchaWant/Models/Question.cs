using System;
using System.Collections.Generic;
using Roughcut.Community.Core.Models.Workflows;

namespace Roughcut.Community.WhatchaWant.Models
{
    public class Question : RoughcutWorkflow
    {
        private string _prompt;
        private Answer _answers;

        public List<Answer> Answers { get; set; }

        public Question()
        {
            this.Answers = new List<Answer>();
        }

        public Question(string prompt)
        {
            this._prompt = prompt;
            //this._answers = answers;
        }
    }
}
