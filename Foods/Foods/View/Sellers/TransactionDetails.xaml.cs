using Foods.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Foods.View.Sellers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransactionDetails : ContentPage
    {
        public TransactionDetails(Transaction transaction)
        {
            BindingContext = transaction ?? throw new ArgumentNullException();

            InitializeComponent();
        }
    }
}