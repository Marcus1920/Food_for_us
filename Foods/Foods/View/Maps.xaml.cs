using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Foods.Services;
using Xamarin.Forms.Maps;
using Plugin.Geolocator;
using System.Diagnostics;

namespace Foods.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Maps : ContentPage
    {
        private Geocoder geoCoder;
public Geocoder GeoCoder { get => geoCoder; set => geoCoder = value; }

        public Maps()
        {

            Title = "New  Location";

            InitializeComponent();
        }

       
        private async void getcurentAsync()
        {
            GeoCoder = new Geocoder(); 

            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 100;
            var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);
             
          string  lattidud = Convert.ToString(position.Latitude);
            EntyAltitude.Text = lattidud;

            EntyLongitutde.Text   = Convert.ToString(position.Longitude);


            var pst = new Position(position.Latitude, position.Longitude);
            //   Debug.WriteLine(pst + "foooool");
            var possibleAddresses = await GeoCoder.GetAddressesForPositionAsync(pst);
            foreach (var address in possibleAddresses)
                revers.Text += address + "\n";
            Debug.WriteLine(possibleAddresses.ToList());
/*
            LocationMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude),

                Distance.FromKilometers(2)));



            var pin = new Pin
            {

                Position = new Position(position.Latitude,position.Longitude),
                Label = "Case number   23",
                Address = "Addresss   64 bowe glenamore"
            };

            pin.Clicked += Pin_clicked;
            LocationMap.Pins.Add(pin);
            */
        }

        private void Pin_clicked(object sender, EventArgs eventArgs)
        {

            var selectedPin = sender as Pin;
            DisplayAlert(selectedPin?.Label, selectedPin?.Address, "OK");

        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            getcurentAsync();

        }

    }
}