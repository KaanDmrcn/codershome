using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace codershome
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            InitializeComponent();
        }

        private void Product1(object sender, EventArgs e)
        {
            var productdetailPage = new ProductDetailPage();
            Application.Current.MainPage.Navigation.PushAsync(productdetailPage);
        }
        private void MainPage(object sender, EventArgs e)
        {
            var mainPage = new MainPage();
            Application.Current.MainPage.Navigation.PushAsync(mainPage);
        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            var loginPage = new LoginPage();
            Application.Current.MainPage.Navigation.PushAsync(loginPage);
        }
        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            var boxPage = new BoxPage();
            Application.Current.MainPage.Navigation.PushAsync(boxPage);
        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            var testPage = new TestPage();
            Application.Current.MainPage.Navigation.PushAsync(testPage);
        }


    }
}