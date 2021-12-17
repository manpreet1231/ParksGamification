using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Parks_Gamification.ViewModels
{
    public class WelcomeViewModel : BaseViewModel
    {
        public WelcomeViewModel()
        {
            Title = "Welcome to the application";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.google.com"));
            GoToTestPageCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(TestViewModel)));

        }

        public ICommand OpenWebCommand { get; }
        public ICommand GoToTestPageCommand { get; }



    }
}