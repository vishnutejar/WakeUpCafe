using System;

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

          void GoToHomePage(object sender, EventArgs e)
        {
            if (welcome.Text.Equals("Welcome"))
            {
                welcome.Text = "Learn";
                description1.Text = "The Most Modern tendencies";
                description2.Text = " along with the ancient ones";
                btnext.Text = "Finish!";
            }
            else if (welcome.Text.Equals("Learn"))
            {
                welcome.Text = "Prepare";
                description1.Text = "To experience Tea like never before.";
                btnext.Text = "Next";
            }
            else if(welcome.Text.Equals("Prepare"))
            {
                App.Current.MainPage = new NavigationPage(new MainMenuPage());
            }

        }

        private void SkipTapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainMenuPage());
        }
    }
}