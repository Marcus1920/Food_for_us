using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Foods.View.Sellers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransactionList : ContentPage
    {
        List<string> GetDummyList()
        {
            return new List<string>
            {
                "First Transaction",
                "Second Transaction",
                "Third Transaction",
                "Fourth Transaction",
                "Fifth Transaction"
            };
        }

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
    }
}