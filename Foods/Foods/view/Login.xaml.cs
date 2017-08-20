using Foods.View.hometabs;
using Foods.View.Sellers;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Foods.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private string _role;

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
            if (_role.Equals("Seller"))
                await Navigation.PushModalAsync(new SellersMaster());

            else
                await Navigation.PushModalAsync(new  Master());
        }

        private void LoginAs_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            _role = LoginAs.Items[LoginAs.SelectedIndex];
        }
    }
}
