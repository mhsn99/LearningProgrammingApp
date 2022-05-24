using System.Collections.Generic;
using LearningApp.Models;

namespace LearningApp.Service
{
    public class Quiz2
    {
        public static IEnumerable<Quiz> GetQuestions()
        {
            var questions = new List<Quiz>
            {
                new Quiz()
                {
                    Id = 1,
                    Question = "1. Which method can be used to return a string in upper case letters?",
                    OptionA = "toUpperCase()",
                    OptionB = "upper()",
                    OptionC = "uppercase()",
                    CorrectOption = "upper()"
                },
                new Quiz()
                {
                    Id=2,
                    Question = "2. Which of these collections defines a LIST?",
                    OptionA = "('banana', 'apple', 'cherry')",
                    OptionB = "'{ 'name': 'Apple', 'color': 'green'}'",
                    OptionC = "['banana', 'apple', 'cherry']",
                    CorrectOption = "['banana', 'apple', 'cherry']"
                },
                new Quiz()
                {
                    Id =3,
                    Question = "3. Which collection is ordered, changeable, and allows duplicate members?",
                    OptionA = "List",
                    OptionB = "Dictionary",
                    OptionC = "Tuple",
                    CorrectOption = "List"
                },
                new Quiz()
                {
                    Id = 4,
                    Question = "4. Which collection does not allow duplicate members?",
                    OptionA = "Tuple",
                    OptionB = "List",
                    OptionC = "Set",
                    CorrectOption = "Set"
                }
            };

            return questions;
        }
    }
}
