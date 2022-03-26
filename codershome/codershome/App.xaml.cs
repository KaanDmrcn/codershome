﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace codershome
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //LoginPage = new LoginPage();
            MainPage = new LoginPage();
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
