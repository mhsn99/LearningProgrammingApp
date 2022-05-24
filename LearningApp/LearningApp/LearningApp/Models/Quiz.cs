namespace LearningApp.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string CorrectOption { get; set; }

    }
}
