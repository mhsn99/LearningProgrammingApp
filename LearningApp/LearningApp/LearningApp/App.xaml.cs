using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LearningApp.View;

namespace LearningApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new MainPage();
            // MainPage = new NavigationPage(new LoginUI());
            // MainPage = new NavigationPage(new Quiz4Page());
            MainPage = new NavigationPage(new Module4Page());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
