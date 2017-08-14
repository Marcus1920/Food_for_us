using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foods.view; 
using Xamarin.Forms;

namespace Foods
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           // myimage.Source = ImageSource.FromFile("b1.png"); 
        }

        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

        private async   void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register()); 
        }
    }
}
