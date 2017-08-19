using Foods.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Foods.View.Sellers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductList : ContentPage
    {
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



        private async Task ProductsListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var product = e.SelectedItem as Product;
            await Navigation.PushAsync(new ProductDetails(product));

            ProductsListView.SelectedItem = null;
        }

        List<Product> GetDummyList()
        {
            return new List<Product>
            {
                new Product
                {
                    Name = "Apples",
                    Descriotion = "Farm fresh produce hand-picked from the best...",
                    Rating = 4.5,
                    Country = "South Africa",
                    City = "Knysna",
                    ImageUrl = "b1.png",
                    Price = 50
                },
                new Product
                {
                    Name = "Bananas",
                    Descriotion = "Nothing beats the taste...",
                    Rating = 5,
                    Country = "South Africa",
                    City = "Knysna",
                    ImageUrl = "b1.png",
                    Price = 30
                },
                new Product
                {
                    Name = "Oranges",
                    Descriotion = "Fine selection...",
                    Rating = 3,
                    Country = "Knysna",
                    City = "Cape Town",
                    ImageUrl = "b1.png",
                    Price = 75
                },
                new Product
                {
                    Name = "Grapes",
                    Descriotion = "The best of the Cape...",
                    Rating = 3,
                    Country = "South Africa",
                    City = "Knysna",
                    ImageUrl = "b1.png",
                    Price = 75
                },
                new Product
                {
                    Name = "Mixed Fruit",
                    Descriotion = "Fine selection...",
                    Rating = 3,
                    Country = "South Africa",
                    City = "Knysna",
                    ImageUrl = "b1.png",
                    Price = 75
                },
                new Product
                {
                    Name = "Oranges",
                    Descriotion = "Fine selection...",
                    Rating = 3,
                    Country = "South Africa",
                    City = "Knysna",
                    ImageUrl = "b1.png",
                    Price = 75
                },
            };
        }
    }
}