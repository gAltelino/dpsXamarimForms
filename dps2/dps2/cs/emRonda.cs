using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;

namespace dps2.cs
{
    class emRonda
    {

        async void enviarPosicao()
        {

            var locator = CrossGeolocator.Current;
            var position = await locator.GetPositionAsync();
            double lat = position.Latitude;
            double longi = position.Longitude;

            await App.Current.MainPage.DisplayAlert("Latitude",lat.ToString(),"Ok");
            await App.Current.MainPage.DisplayAlert("Longitude", longi.ToString(), "Ok");

        }

    }
}
