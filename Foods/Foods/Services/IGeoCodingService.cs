using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

namespace Foods.Services
{
  public    interface IGeoCodingService
    {

        Position NullPosition { get;}

        Task<Position> GeoCodingAddress(string addressString);

        Task<IEnumerable<string>> ReverseGeoCodePosition(Double latitude, Double longitude);

        Task<Plugin.Geolocator.Abstractions.Position> GetGetCurentLocation();
    }
}
