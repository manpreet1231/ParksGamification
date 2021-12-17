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
            GoToTestPageCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(Views.TestPage)));

            var park = new Models.Park();
            park.Id = 1;
            park.Name = "GreenPark";
            park.Description = "This is and awesome park";

            park.Amenities.Add(new Models.Park.Amenity() { Type = Models.Park.Amenity.Types.Swing, Description = "Blue swing set for ages 3 to 7."});
            park.Amenities.Add(new Models.Park.Amenity() { Type = Models.Park.Amenity.Types.Swing, Description = "Green swing set for ages 3 to 7." });

        }

        public ICommand OpenWebCommand { get; }
        public ICommand GoToTestPageCommand { get; }



    }
}