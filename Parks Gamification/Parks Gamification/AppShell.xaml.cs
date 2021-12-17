using Parks_Gamification.ViewModels;
using Parks_Gamification.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Parks_Gamification
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TestPage), typeof(TestPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
        }
    }
}
