﻿using Pilot.Services;
using Pilot.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pilot
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new TabbedPage1();
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
