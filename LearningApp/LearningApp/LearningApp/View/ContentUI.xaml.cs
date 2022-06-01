﻿using LearningApp.Models;
using LearningApp.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearningApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentUI : ContentPage
    {
        public List<Module> AllModules { get; set; }
        public ContentUI(List<Module> sources)
        {
            InitializeComponent();
            if(sources != null)
            {
                AllModules = sources;
            }
            else
            {
                AllModules = new List<Module>(Modules.GetModules());
            }
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            collectionViewListVertical.ItemsSource = AllModules;
        }

        void CollectionViewListSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigateNewPage(e.PreviousSelection, e.CurrentSelection);
        }

        
        

        void NavigateNewPage(IEnumerable<object> previousSelectedModule, IEnumerable<object> currentSelectedModule)
        {
            var selectedModule = currentSelectedModule.FirstOrDefault() as Module;
            Debug.WriteLine("Module Name: " + selectedModule.ModuleName);
            Debug.WriteLine("Module Desc: " + selectedModule.ModuleDesc);
            
            // Tıkladığı module göre ilgili modülün sayfasına geçecek şuan sadece birinci modül sayfasına geçiş yapıyor
            if (selectedModule.ModuleName.ToString() == "Module 1: Hello World")
            {
                // Application.Current.MainPage.Navigation.PushModalAsync(new Module1Page(), true);
                Navigation.PushModalAsync(new Module1Page(AllModules));
            }
            if (selectedModule.ModuleName.ToString() == "Module 2: Collections")
            {
                //Application.Current.MainPage.Navigation.PushModalAsync(new Module1Page(), true);
                Navigation.PushModalAsync(new Module2Page(AllModules));
            }
            if (selectedModule.ModuleName.ToString() == "Module 3: Condition")
            {
                //Application.Current.MainPage.Navigation.PushModalAsync(new Module3Page(), true);
                Navigation.PushModalAsync(new Module3Page(AllModules));
            }
            if (selectedModule.ModuleName.ToString() == "Module 4: Loops")
            {
                //Application.Current.MainPage.Navigation.PushModalAsync(new Module4Page(), true);
                Navigation.PushModalAsync(new Module4Page(AllModules));
            }


        }
    }
}