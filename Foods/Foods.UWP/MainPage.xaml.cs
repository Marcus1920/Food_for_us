using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Foods.UWP
{
    public sealed partial class MainPage
    {

        public MainPage()
        {
            this.InitializeComponent();
            Xamarin.FormsMaps.Init("4dKvJB2XDN9iXnYBz7ih~G2PiBFmagzO7188fwcyOfw~ApKB1qVa5q9Qv8IPh_wEsV29rJgrEL2ekpWPWHwE5Pt7W7a0DZEUFwv6_cfoZLOy");

            LoadApplication(new Foods.App());
        }
    }
}
