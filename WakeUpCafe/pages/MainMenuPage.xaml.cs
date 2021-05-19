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
        }

        private void NavigateSeelctedPage(object sender, SelectedItemChangedEventArgs e)
        {
            var postion = e.SelectedItem as MenuItems;
            DisplayAlert("", postion.Title, "0k");


        }
    }
}