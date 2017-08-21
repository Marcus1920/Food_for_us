using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foods.view;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;
using System.Diagnostics;
using Plugin.Geolocator;

namespace Foods.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        private Geocoder geoCoder;
        public Geocoder GeoCoder { get => geoCoder; set => geoCoder = value; }

        public Register()
        {
            InitializeComponent();
        }
        private async void getcurentAsync()
        {
            GeoCoder = new Geocoder();

            var locator = CrossGeolocator.Current;
           locator.DesiredAccuracy = 100;
            var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);

            string lattidud = Convert.ToString(position.Latitude);
          //  EntyAltitude.Text = lattidud;

           // EntyLongitutde.Text = Convert.ToString(position.Longitude);


            var pst = new Position(position.Latitude, position.Longitude);
            //   Debug.WriteLine(pst + "foooool");
            var possibleAddresses = await GeoCoder.GetAddressesForPositionAsync(pst);
            foreach (var address in possibleAddresses)
                mylocation.Text += address + "\n";
            Debug.WriteLine(possibleAddresses.ToList());
           
        }
        private async Task Register_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Homepage());

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            getcurentAsync();

        }
    }
}