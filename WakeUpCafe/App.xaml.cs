using System;
using WakeUpCafe.pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WakeUpCafe
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new WelcomePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
