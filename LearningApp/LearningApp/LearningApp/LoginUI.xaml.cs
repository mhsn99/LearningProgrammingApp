using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LearningApp.View;

namespace LearningApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }
        public void LoginClicked(object sender, EventArgs e)
        {
            if (txtUsername.Text == "FZD" && txtpassword.Text == "0122")
            {
                Navigation.PushAsync(new ContentUI(null));
            }
            else
            {
                DisplayAlert("Oops...", "Something is wrong", "OK");
            }
        }
    }
}