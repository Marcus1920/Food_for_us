using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Foods.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private async Task Register_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Homepage());

        }
    }
}