using App1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
    internal class SurveyDetailsViewModel : NotificationObject
    {
        private string name;

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                OnPropertychanged();
            }
        }

        private string favouriteFood;

        public string FavouriteFood
        {
            get { return this.favouriteFood; }
            set
            {
                this.favouriteFood = value;
                OnPropertychanged();
            }
        }

        public ICommand SaveCommand { get; set; }

        public SurveyDetailsViewModel()
        {
            SaveCommand = new Command(() =>
            {
                var newSurvey = new Survey
                {
                    Name = this.name,
                    FavouriteFood = this.favouriteFood
                };
                MessagingCenter.Send(this, "SaveSurvey", newSurvey);
            });
        }

    }
}
