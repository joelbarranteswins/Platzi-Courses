﻿using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<MainPageViewModel>(this, "AddSurvey", async (a) =>
            {
                await Navigation.PushModalAsync(new SurveyDetailsView());
            });
        }
    }
}
