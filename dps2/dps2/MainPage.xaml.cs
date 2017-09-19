using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Geolocator;

namespace dps2
{
    public partial class MainPage : ContentPage

    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 50;

                var position = await locator.GetPositionAsync(timeoutMilliseconds:10000);
                //testeLong.Text = position.Longitude.ToString();

                testeLong.Text = position.Longitude.ToString();

            }
            catch(Exception ex)
            {
                testeLong.Text = ex.ToString();
            }

        }
    }
}
