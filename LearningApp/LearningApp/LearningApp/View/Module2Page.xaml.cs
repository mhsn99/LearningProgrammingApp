﻿using LearningApp.Models;
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
    public partial class Module2Page : ContentPage
    {
        public List<Module> AllModules { get; set; }
        public Module2Page(List<Module> sources)
        {
            InitializeComponent();
            AllModules = sources;
        }
        void redirectToQuiz(System.Object sender, System.EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new Quiz2Page(AllModules), true);
        }
    }
}