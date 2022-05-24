using System.Collections.Generic;
using LearningApp.Models;

namespace LearningApp.Service
{
    public class Quiz1
    {
        public static IEnumerable<Quiz> GetQuestions()
        {
            var questions = new List<Quiz>
            {
                new Quiz()
                {
                    Id = 1,
                    Question = "1. What is a correct syntax to output 'Hello World' in Python?",
                    OptionA = "cout <<'Hello World'",
                    OptionB = "print('Hello World')",
                    OptionC = "echo('Hello World');",
                    CorrectOption = "print('Hello World')"
                },
                new Quiz()
                {
                    Id= 2,
                    Question = "2. How do you insert COMMENTS in Python code?",
                    OptionA = "#This is a comment",
                    OptionB = "//This is a comment",
                    OptionC = "/*This is a comment*/",
                    CorrectOption = "#This is a comment"
                },
                new Quiz()
                {
                    Id = 3,
                    Question = "3. Which one is NOT a legal variable name?",
                    OptionA = "my_var",
                    OptionB = "_myvar",
                    OptionC = "my-var",
                    CorrectOption = "my-var"
                },
                new Quiz()
                {
                    Id = 4,
                    Question = "4. How do you create a variable with the numeric value 5?",
                    OptionA = "x = 5",
                    OptionB = "x = int(5)",
                    OptionC = "Both the other answers are correct",
                    CorrectOption = "Both the other answers are correct"
                }
            };

            return questions;
        }
    }
}
