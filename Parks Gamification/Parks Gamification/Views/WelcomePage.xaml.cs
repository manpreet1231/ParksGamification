using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parks_Gamification.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();

            BindingContext = new ViewModels.WelcomeViewModel();

            var learnMoreButton = new Button() {Text = "LEAEN MORE" };
            learnMoreButton.SetBinding(Button.CommandProperty, new Binding("OpenWebCommand"));

            var testButton = new Button() { Text = "Go to test page" };
            testButton.SetBinding(Button.CommandProperty, new Binding("GoToTestPageCommand"));

            Content = new StackLayout() { Padding = 30 , Children = { learnMoreButton, testButton } };
        }
    }
}