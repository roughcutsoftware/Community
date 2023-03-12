using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using Roughcut.Community.WhatchaWant.Models;

namespace Roughcut.Community.WhatchaWant.Tests
{
    [TestFixture]
    public class QuizServiceTests
    {

        [Test]
        public void Should_BeFailedQuiz()
        {
            Quiz quiz = new Quiz();

            Question question = new Question("What is your name?: ")
            {
                Answers = new List<Answer>()
                {
                    new Answer("John") { }
                }
                
            };
            quiz.Questions.Add(question);

            quiz.Result().Should().BeFalse();
        }

 
    }
}
