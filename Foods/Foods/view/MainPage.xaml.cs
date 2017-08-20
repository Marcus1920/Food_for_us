using Foods.view;
using System;
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
