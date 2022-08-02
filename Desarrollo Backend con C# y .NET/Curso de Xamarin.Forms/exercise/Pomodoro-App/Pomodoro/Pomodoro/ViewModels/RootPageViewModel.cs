using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Pomodoro.ViewModels
{
    public class RootPageViewModel : NotificationObject
    {
        private ObservableCollection<string> menuItems;

        public ObservableCollection<string> MenuItems
        {
            get
            {
                return menuItems;
            }
            set
            {
                menuItems = value;
                OnPropertyChanged();
            }
        }

        private string selectedMenuItem;

        public string SelectedMenuItem
        {
            get
            {
                return selectedMenuItem;
            }
            set
            {
                selectedMenuItem = value;
                OnPropertyChanged();
            }
        }

        public RootPageViewModel()
        {
            MenuItems = new ObservableCollection<string>();
            MenuItems.Add("Pomodoro");
            MenuItems.Add("Histórico");
            MenuItems.Add("Configuración");

            PropertyChanged += RootPageViewModel_PropertyChanged;
        }

        private void RootPageViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(SelectedMenuItem))
            {
                if (SelectedMenuItem == "Pomodoro")
                {
                    MessagingCenter.Send(this, "GoToPomodoro");
                }

                if (SelectedMenuItem == "Histórico")
                {
                    MessagingCenter.Send(this, "GoToHistory");
                }


                if (SelectedMenuItem == "Configuración")
                {
                    MessagingCenter.Send(this, "GoToConfiguration");
                }

                
            }
        }
    }
}