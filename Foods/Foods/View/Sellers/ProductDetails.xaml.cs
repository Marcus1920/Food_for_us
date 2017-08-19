using Foods.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Foods.View.Sellers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetails : ContentPage
    {
        public ProductDetails(Product product)
        {
            BindingContext = product ?? throw new ArgumentNullException();

            InitializeComponent();
        }
    }
}