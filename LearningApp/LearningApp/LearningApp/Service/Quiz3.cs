using System.Collections.Generic;
using LearningApp.Models;


namespace LearningApp.Service
{
    public class Quiz3
    {
        public static IEnumerable<Quiz> GetQuestions()
        {
            var questions = new List<Quiz>
            {
                new Quiz()
                {
                    Id = 1,
                    Question = "1. How do you start writing an if statement in Python?",
                    OptionA = "if (x>y)",
                    OptionB = "if x>y then:",
                    OptionC = "if x>y:",
                    CorrectOption = "if x>y:"
                },
                new Quiz()
                {
                    Id=2,
                    Question = "2. In a Python program, a control structure:...",
                    OptionA = "Directs the order of execution of the statements in the program.",
                    OptionB = "Dictates what happens before the program starts and after it terminates.",
                    OptionC = "Defines program-specific data structures",
                    CorrectOption = "Directs the order of execution of the statements in the program."
                },
                new Quiz()
                {
                    Id = 3,
                    Question = "3. Which Python statement will check to see if a is greater than b?",
                    OptionA = "if a is greater than b",
                    OptionB = "if a > b:",
                    OptionC = "if a >= b:",
                    CorrectOption = "if a > b:"
                },
                new Quiz()
                {
                    Id= 4,
                    Question = "4. How many choices are possible when using a single if-else statement?",
                    OptionA = "1",
                    OptionB = "2",
                    OptionC = "4",
                    CorrectOption = "2"
                }
            };

            return questions;
        }
    }
}
