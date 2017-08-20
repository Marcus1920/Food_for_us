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
                    Description = "Farm fresh produce hand-picked from the best...",
                    Rating = 4.5,
                    Country = "South Africa",
                    City = "Knysna",
                    ImageUrl = "apples.png",
                    Price = 50
                },
                new Product
                {
                    Name = "Bananas",
                    Description = "Nothing beats the taste...",
                    Rating = 5,
                    Country = "South Africa",
                    City = "Knysna",
                    ImageUrl = "bananas.png",
                    Price = 30
                },
                new Product
                {
                    Name = "Cabbage",
                    Description = "Nothing beats the taste...",
                    Rating = 5,
                    Country = "South Africa",
                    City = "Knysna",
                    ImageUrl = "cabbage.png",
                    Price = 30
                },
                new Product
                {
                    Name = "Oranges",
                    Description = "Fine selection...",
                    Rating = 3,
                    Country = "South Africa",
                    City = "Knysna",
                    ImageUrl = "oranges2.jpg",
                    Price = 75
                },
                new Product
                {
                    Name = "Grapes",
                    Description = "The best of the Cape...",
                    Rating = 3,
                    Country = "South Africa",
                    City = "Knysna",
                    ImageUrl = "grapes.jpg",
                    Price = 75
                },
                new Product
                {
                    Name = "Potatoes",
                    Description = "The best of the Cape...",
                    Rating = 3,
                    Country = "South Africa",
                    City = "Knysna",
                    ImageUrl = "potatoes.png",
                    Price = 75
                },
                new Product
                {
                    Name = "Mixed Fruit",
                    Description = "Fine selection...",
                    Rating = 3,
                    Country = "South Africa",
                    City = "Knysna",
                    ImageUrl = "mixedfruit.jpg",
                    Price = 75
                },
                new Product
                {
                    Name = "Oranges",
                    Description = "Fine selection...",
                    Rating = 3,
                    Country = "South Africa",
                    City = "Knysna",
                    ImageUrl = "oranges.jpg",
                    Price = 75
                },
            };
        }
    }
}