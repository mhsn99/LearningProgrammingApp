using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearningApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPopUp : Popup
    {
        public ResultPopUp(float score)
        {
            InitializeComponent();
            scoreTextLabel.Text = "Your Score: " + score.ToString();
            scoreTextLabel.FontSize = 55;
            scoreTextLabel.FontAttributes = FontAttributes.Bold;
            scoreTextLabel.TextColor = Color.DodgerBlue;
        }

        private void BtnClose_Clicked(object sender, EventArgs e)
        {
            Dismiss(null);
        }
    }
}