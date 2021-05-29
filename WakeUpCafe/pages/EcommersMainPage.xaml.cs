using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WakeUpCafe.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EcommersMainPage : ContentPage
    {
        IList<string> carouselviewdata = new ObservableCollection<string>();
        public EcommersMainPage()
        {
            InitializeComponent();
            carouselviewdata.Add("cofffe1.jpg");
            carouselviewdata.Add("cofffe1.jpg");
            carouselviewdata.Add("cofffe1.jpg");
            carouselviewdata.Add("cofffe1.jpg");
            carouselview.ItemsSource = carouselviewdata;
        }
    }
}