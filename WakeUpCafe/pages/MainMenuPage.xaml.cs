using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WakeUpCafe.models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WakeUpCafe.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenuPage : FlyoutPage
    {
        ObservableCollection<MenuItems> listOfMenuItems { get; set; }
        public MainMenuPage()
        {
            InitializeComponent();
            setMenuData();
            listviewMenu.ItemsSource = listOfMenuItems;
        }

        private void setMenuData()
        {
            listOfMenuItems = new ObservableCollection<MenuItems>();
            listOfMenuItems.Add(new MenuItems { IconSource = "icon.png", Title = "Shop MainPage",Position=0});
            listOfMenuItems.Add(new MenuItems { IconSource = "icon.png", Title = "Location",Position=1});
            listOfMenuItems.Add(new MenuItems { IconSource = "icon.png", Title = "About",Position=2});
            listOfMenuItems.Add(new MenuItems { IconSource = "icon.png", Title = "LogOut",Position=3});
        }

        private void NavigateSeelctedPage(object sender, SelectedItemChangedEventArgs e)
        {
            var postion = e.SelectedItem as MenuItems;
            DisplayAlert("", postion.Title, "0k");

            switch (postion.Position) {

                case 0:
                    Navigation.PushAsync(new Page());
                    break;
                case 2:
                    Navigation.PushAsync(new ContactUsPage());
                    break;
                case 3:
                    Navigation.PopToRootAsync();
                    break;

            }
        }
    }
}