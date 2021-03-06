﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroToXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new PageA());
            navPage.BarTextColor = Color.DeepPink;

            MainPage = new MyTabbedPage(); //navPage;
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
