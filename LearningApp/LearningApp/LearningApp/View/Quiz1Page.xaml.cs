using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningApp.Models;
using LearningApp.Service;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearningApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quiz1Page : ContentPage
    {
        float score = 0;
        float correct = 0;
        string correctans;

        public List<Quiz> AllQuestions = new List<Quiz>(Quiz1.GetQuestions());
        public List<Module> modules = new List<Module>(Modules.GetModules());
        int qIndex = 1;
        float prgValue = 0;
        readonly int qCount;
        readonly string[] userAnswers;
        readonly string[] clickedRadio;
        public Quiz1Page()
        {
            
            InitializeComponent();
            correct = 0;
            qCount = AllQuestions.Count;
            clickedRadio = new string[qCount];
            userAnswers = new string[qCount];
            QuestionNumberLabel.Text = qIndex + "/" + qCount;
            score = 0;
            SetQuestion(qIndex);
            CorrectAnswers();
            Debug.WriteLine(qCount);
        }

        /// <summary>
        /// Places questions and options in elements. Returns the answer to the question based on the question number.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private string SetQuestion(int id)
        {
            Quiz quiz = AllQuestions.Where(x => x.Id == id).SingleOrDefault();
            QuestionLabel.Text = quiz.Question.ToString();
            R1.Content = quiz.OptionA;
            R2.Content = quiz.OptionB;
            R3.Content = quiz.OptionC;
            correctans = quiz.CorrectOption;

            if (clickedRadio[id-1] != null)
            {
                if(clickedRadio[id-1].ToString() == R1.ClassId)
                {
                    R1.IsChecked = true;
                    R2.IsChecked = false;
                    R3.IsChecked = false;
                }
                else if(clickedRadio[id-1].ToString() == R2.ClassId)
                {
                    R1.IsChecked = false;
                    R2.IsChecked = true;
                    R3.IsChecked = false;
                }
                else
                {
                    R1.IsChecked = false;
                    R2.IsChecked = false;
                    R3.IsChecked = true;
                }
            }
            else
            {
                R1.IsChecked = false;
                R2.IsChecked = false;
                R3.IsChecked = false;
            }

            BtnBack.IsEnabled = id != 1;
            BtnNext.IsEnabled = id != qCount;
            return correctans;
        }

        /// <summary>
        /// The function that gives the feedback with pictures and text according to the answer given to the question.
        /// </summary>
        /// <param name="id"></param>
        void ShowCorrectOrFalseImage(int id)
        {
            if (userAnswers[id - 1] == CorrectAnswers().ElementAt(id - 1))
            {
                CorrectOrFalseImg.Source = "correct.png";
                CorrectOrFalseLabel.Text = "Correct!";
                CorrectOrFalseLabel.TextColor = Color.Lime;
            }
            else
            {
                CorrectOrFalseImg.Source = "imgfalse.png";
                CorrectOrFalseLabel.Text = "Wrong Answer!";
                CorrectOrFalseLabel.TextColor = Color.Red;
            }

            if(userAnswers[id - 1] == null)
            {
                CorrectOrFalseImg.Source = "empty.png";
                CorrectOrFalseLabel.Text = "You did not select!";
                CorrectOrFalseLabel.TextColor = Color.LightSeaGreen;
            }
            
        }

        /// <summary>
        /// The function that ensures that the option selected in the previous question does not change when the new question is passed.
        /// </summary>
        /// <param name="id"></param>
        private void SetClickedRadioButton(int id)
        {

            if (R1.IsChecked)
            {
                clickedRadio[id - 1] = R1.ClassId;
                userAnswers[id - 1] = R1.Content.ToString();
            }
            if (R2.IsChecked)
            {
                clickedRadio[id - 1] = R2.ClassId;
                userAnswers[id - 1] = R2.Content.ToString();
                
            }
            if (R3.IsChecked)
            {
                clickedRadio[id - 1] = R3.ClassId;
                userAnswers[id - 1] = R3.Content.ToString();
                
            }    
        }

        /// <summary>
        /// Function that returns a list of correct answers of questions.
        /// </summary>
        /// <returns></returns>
        private List<string> CorrectAnswers()
        {
            List<string> answer = new List<string>();
            Quiz ans;
            for (int i = 0; i < AllQuestions.Count; i++)
            {
                ans = AllQuestions.Where(x=> x.Id == i+1).SingleOrDefault();
                answer.Add(ans.CorrectOption);
            }
            return answer;
        }

        /// <summary>
        /// Function that updates the completion rate of the module in question after the quiz is completed.
        /// </summary>
        /// <returns></returns>
        private List<Module> UpdatedModule()
        {
            foreach (var item in modules.Where(x=>x.ModuleId == 1))
            {
                item.PrgWidth = prgValue;
            }
            return modules;
        }

        /// <summary>
        /// Function that compares the user's answers with the correct answers.
        /// </summary>
        public void CheckAnswers()
        {
            CorrectAnswers();
            for (int i = 0; i < qCount; i++)
            {
                if (userAnswers[i] != null)
                {
                    if (userAnswers[i] == CorrectAnswers().ElementAt(i))
                    {
                        correct++;
                    }
                }
            }
        }

        /// <summary>
        /// Navigates to the page with the module names.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReturnContent_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentUI(UpdatedModule()));
            Debug.WriteLine("score: " + score);
        }

        /// <summary>
        /// Calculates the results.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            R1.IsEnabled = false;
            R2.IsEnabled = false;
            R3.IsEnabled = false;
            ShowCorrectOrFalseImage(qIndex);
            CheckAnswers();
            SubmitLayout.IsVisible = false;
            InfoLayout.IsVisible = true;
            ReturnContentLayout.IsVisible = true;

            score = correct * (100/qCount);
            ScoreLabel.Text = "Score: " + score;
            prgValue = score / 100;
            if (score > 75)
            {
                ScoreLabel.TextColor = Color.Green;
            }
            else if (score > 50)
            {
                ScoreLabel.TextColor = Color.Orange;
            }
            else
            {
                ScoreLabel.TextColor = Color.Red;
            }

            ScoreInfoLayout.IsVisible = true;
            

            Debug.WriteLine("prg: " + prgValue);
            Debug.WriteLine("Score is = " + score);
            Navigation.ShowPopup(new ResultPopUp(score)
            {
                IsLightDismissEnabled = false
            });
        }

        /// <summary>
        /// It navigates next question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNext_Clicked(object sender, EventArgs e)
        {
            qIndex++;
            SetQuestion(qIndex);
            QuestionNumberLabel.Text = qIndex + "/" + qCount;
            ShowCorrectOrFalseImage(qIndex);
        }

        /// <summary>
        /// It navigates previous question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBack_Clicked(object sender, EventArgs e)
        {
            qIndex--;
            SetQuestion(qIndex);
            QuestionNumberLabel.Text = qIndex + "/" + qCount;
            ShowCorrectOrFalseImage(qIndex);
        }

        /// <summary>
        /// Function that ensures what happens when the user changes options.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Radio_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            SetClickedRadioButton(qIndex);
        }
    }
}