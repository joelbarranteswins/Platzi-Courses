using System;
using Pomodoro.ViewModels;
using Pomodoro.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pomodoro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RootPage : MasterDetailPage
    {
        public RootPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<RootPageViewModel>(this, "GoToPomodoro", (a) =>
            {
                Detail = new NavigationPage(new PomodoroPage());
                IsPresented = false;
            });
            MessagingCenter.Subscribe<RootPageViewModel>(this, "GoToHistory", (a) =>
            {
                Detail = new NavigationPage(new HistoryPage());
                IsPresented = false;
            });
            MessagingCenter.Subscribe<RootPageViewModel>(this, "GoToConfiguration", (a) =>
            {
                Detail = new NavigationPage(new ConfigurationPage());
                IsPresented = false;
            });
        }

        //private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var item = e.SelectedItem as RootPageMenuItem;
        //    if (item == null)
        //        return;

        //    var page = (Page)Activator.CreateInstance(item.TargetType);
        //    page.Title = item.Title;

        //    //MasterPage.ListView.SelectedItem = null;
        //}
    }
}