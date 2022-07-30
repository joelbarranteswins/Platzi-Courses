using App1.Models;
using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SurveyDetailsView : ContentPage
    {
        public SurveyDetailsView()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<SurveyDetailsViewModel, Survey>(this, "SaveSurvey", async (a, s) =>
            {
                await Navigation.PopModalAsync();
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<SurveyDetailsViewModel, Survey>(this, "SaveSurvey");
        }
    }
}