using Foods.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Foods.View.Sellers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransactionDetails : ContentPage
    {
        private readonly Transaction _transaction;

        public TransactionDetails(Transaction transaction)
        {
            _transaction = transaction;

            BindingContext = _transaction ?? throw new ArgumentNullException();

            InitializeComponent();
        }

        private void Complete_OnClicked(object sender, EventArgs e)
        {
            _transaction.IsComplete = !_transaction.IsComplete;

            InitializeComponent();
        }

        private void Progress_OnClicked(object sender, EventArgs e)
        {
            _transaction.IsComplete = !_transaction.IsComplete;

            InitializeComponent();
        }

        private async void Delete_OnClicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Delete?", "Are you sure you want to delete this transaction?", "Yes", "No"))
                await DisplayAlert(null,"Delete functionality coming soon!", "Ok");
        }
    }
}