﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGuiaDev
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Propriedade que Define a página inicial
            MainPage = new MainPage();
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
