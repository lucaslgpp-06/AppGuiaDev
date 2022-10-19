﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Xamarin.Forms.OpenWhatsApp;

namespace AppGuiaDev.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contato : ContentPage
    {
        public Contato()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Telefone
            try
            {
                await Launcher.OpenAsync("tel:+1436223566");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, deu um erro", ex.Message, "OK");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            // E-Mail
            try
            {
                await Launcher.OpenAsync("mailto:e070dir@cps.sp.gov.br");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, deu um erro", ex.Message, "OK");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            // E-Mail
            try
            {
                Chat.Open("+1436223566", "E ae, fala mais do curso de TI");
            }
            catch (Exception ex)
            {
                if(await DisplayAlert("Ops, deu um erro", "Não conseguimos abrir o WhatsApp. Quer ligar para (14) 3622-3566 ?", "Ligar", "Agora Não"))
                {
                    await Launcher.OpenAsync("tel:+551436223566");
                }
               

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }
    }
}