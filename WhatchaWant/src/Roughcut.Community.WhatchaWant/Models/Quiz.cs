using System;
using System.Collections.Generic;
using System.Text;

namespace Roughcut.Community.WhatchaWant.Models
{
    public class Quiz
    {
        public List<Question> Questions { get; set; }

        public Quiz()
        {
            this.Questions = new List<Question>();
        }

        public bool Result()
        {
            return false;

        }
    }
}
