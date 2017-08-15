using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foods.view; 
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Foods.View.hometabs;

namespace Foods.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void forgepassword_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Forgetpassword());
        }
   


        private async Task login_Clicked_1Async(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new  Master());
        }
    }
}
