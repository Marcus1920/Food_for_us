using Foods.Model;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Foods.View.Sellers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransactionList : ContentPage
    {
        public TransactionList()
        {
            InitializeComponent();

            TransactionsListView.ItemsSource = GetDummyList();
        }

        private void TransactionsListView_OnRefreshing(object sender, EventArgs e)
        {
            TransactionsListView.ItemsSource = GetDummyList();
            TransactionsListView.EndRefresh();
        }

        List<Transaction> GetDummyList()
        {
            return new List<Transaction>
            {
                new Transaction
                {
                    CustomerImageUrl = "b1.png",
                    CustomerName = "Babalo Cetywa",
                    Description = "10kg Apples requested..",
                    Date = DateTime.Now.AddDays(-2).AddHours(+3),
                    IsComplete = true
                },
                new Transaction
                {
                    CustomerImageUrl = "b1.png",
                    CustomerName = "Fellow Mtshali",
                    Description = "5kg Oranges requested..",
                    Date = DateTime.Now.AddDays(-1).AddHours(+5),
                    IsComplete = false
                },
                new Transaction
                {
                    CustomerImageUrl = "b1.png",
                    CustomerName = "Brian Thomas",
                    Description = "25kg Grapes requested..",
                    Date = DateTime.Now.AddDays(-4).AddHours(+3),
                    IsComplete = true
                },
                new Transaction
                {
                    CustomerImageUrl = "b1.png",
                    CustomerName = "Marcus Mbayo",
                    Description = "10kg Apples requested..",
                    Date = DateTime.Now.AddDays(-2).AddHours(+3),
                    IsComplete = true
                },
                new Transaction
                {
                    CustomerImageUrl = "b1.png",
                    CustomerName = "Babalo Cetywa",
                    Description = "10kg Apples requested..",
                    Date = DateTime.Now.AddDays(-2).AddHours(+3),
                    IsComplete = true
                },
                new Transaction
                {
                    CustomerImageUrl = "b1.png",
                    CustomerName = "Olwethu Ngobese",
                    Description = "10kg Apples requested..",
                    Date = DateTime.Now.AddDays(-2).AddHours(+3),
                    IsComplete = false
                },
                new Transaction
                {
                    CustomerImageUrl = "b1.png",
                    CustomerName = "Babalo Cetywa",
                    Description = "10kg Apples requested..",
                    Date = DateTime.Now.AddDays(-2).AddHours(+3),
                    IsComplete = true
                },
                new Transaction
                {
                    CustomerImageUrl = "b1.png",
                    CustomerName = "Babalo Cetywa",
                    Description = "10kg Apples requested..",
                    Date = DateTime.Now.AddDays(-2).AddHours(+3),
                    IsComplete = false
                },
            };
        }
    }
}