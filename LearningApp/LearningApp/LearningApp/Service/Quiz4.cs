using System.Collections.Generic;
using LearningApp.Models;

namespace LearningApp.Service
{
    public class Quiz4
    {
        public static IEnumerable<Quiz> GetQuestions()
        {
            var questions = new List<Quiz>
            {
                new Quiz()
                {
                    Id =  1,
                    Question = "1. Which statement is used to stop a loop?",
                    OptionA = "exit",
                    OptionB = "return",
                    OptionC = "break",
                    CorrectOption = "break"
                },
                new Quiz()
                {
                    Id = 2,
                    Question = "2. How do you start writing a for loop in Python?",
                    OptionA = "for x in y:",
                    OptionB = "for each x in y:",
                    OptionC = "for x>y:",
                    CorrectOption = "for x in y:"
                },
                new Quiz()
                {
                    Id =3,
                    Question = "3. How do you start writing a while loop in Python?",
                    OptionA = "while x>y {...}",
                    OptionB = "while (x>y) {...}",
                    OptionC = "while x>y: ...",
                    CorrectOption = "while x>y: ..."
                }
                
            };

            return questions;
        }
    }
}
