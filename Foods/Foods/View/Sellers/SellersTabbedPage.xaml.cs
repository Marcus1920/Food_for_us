
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Foods.View.Sellers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SellersTabbedPage : TabbedPage
    {
        public SellersTabbedPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                if (await DisplayAlert("Exit page?", "Are you sure you want to exit this page? You will will be logged out if you continue.", "Yes, continue", "No"))
                {
                    base.OnBackButtonPressed();

                    await Navigation.PopModalAsync();
                }
            });

            return true;
        }
    }
}