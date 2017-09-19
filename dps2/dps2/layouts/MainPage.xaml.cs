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

                double longitude = position.Longitude;
                double latitude = position.Latitude;
                string cpf = "36471042809"; //cpf fixo para teste inicial


                //Após obter os dados tenta realizar o envio para a API via HTTP
                //            http://localhost:6538/Funcionario/GravarLocalizacao?cpf=36471042809&lat=-23,0235097&lng=-45,5754652


            }
            catch (Exception ex)
            {
                testeLong.Text = ex.ToString();
            }

        }
    }
}
