using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foods.view;

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
            await Navigation.PushAsync(new Homepage());

        }
    }
}