using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WakeUpCafe.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void GoToHomePage(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainMenuPage());

        }

        private void SkipTapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainMenuPage());
        }
    }
}