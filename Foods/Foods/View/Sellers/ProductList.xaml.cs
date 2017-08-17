using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Foods.View.Sellers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductList : ContentPage
    {
        List<string> GetDummyList()
        {
            return new List<string>
            {
                "First Product",
                "Second Product",
                "Third Product",
                "Fourth Product",
                "Fifth Product"
            };
        }

        public ProductList()
        {
            InitializeComponent();
            
            ProductsListView.ItemsSource = GetDummyList();
        }

        private void ProductsListView_OnRefreshing(object sender, EventArgs e)
        {
            ProductsListView.ItemsSource = GetDummyList();
            ProductsListView.EndRefresh();
        }
    }
}