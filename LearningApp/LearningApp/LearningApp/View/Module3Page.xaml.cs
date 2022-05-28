using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearningApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Module3Page : ContentPage
    {
        public Module3Page()
        {
            InitializeComponent();
        }

        void redirectToQuiz(System.Object sender, System.EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new Quiz1Page(), true);
        }
    }
}