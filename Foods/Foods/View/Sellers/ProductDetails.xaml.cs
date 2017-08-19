using Foods.Model;
using System;
using System.Threading.Tasks;
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

        private async Task Button_OnClicked(object sender, EventArgs e)
        {
            var respone = await DisplayActionSheet("ACTIONS", "Cancel", null, "Edit", "Save", "Delete");

            if (!respone.Equals("Cancel"))
            {
                if (respone.Equals("Delete"))
                {
                    var delete = await DisplayAlert(respone + "?", "Are you want to remove this post?", "Yes", "No");
                    if (delete)
                        await DisplayAlert(null, respone + " functionality coming soon!", "Ok");
                }

                else
                    await DisplayAlert(null, respone + " functionality coming soon!", "Ok");
            }
        }
    }
}