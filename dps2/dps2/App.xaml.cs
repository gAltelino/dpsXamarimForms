﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace dps2
{
    
    public partial class App : Application
        {

        public static bool IsUserLoggedIn { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new dps2.mapa();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}