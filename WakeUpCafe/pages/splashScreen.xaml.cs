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
    public partial class splashScreen : ContentPage
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void GotoMainMenuPage(object sender, EventArgs e)
        {
           // Navigation.PushAsync(new MainMenuPage());
            App.Current.MainPage = new NavigationPage(new MainMenuPage());
        }
    }
}