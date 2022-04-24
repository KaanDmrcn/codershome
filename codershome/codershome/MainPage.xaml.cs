using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace codershome
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            var loginPage = new LoginPage();
            Application.Current.MainPage.Navigation.PushAsync(loginPage);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var productsPage = new ProductsPage();
            Application.Current.MainPage.Navigation.PushAsync(productsPage);
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            var boxPage = new BoxPage();
            Application.Current.MainPage.Navigation.PushAsync(boxPage);
        }
    }
}
