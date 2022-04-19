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

        
    }
}