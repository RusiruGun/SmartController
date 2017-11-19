using SmartController.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartController
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            Device.ItemsSource = new List<DeiceModel>
            {
                new DeiceModel
                {
                    Name="Device 1",
                    DeviceID="A4:8C:91:EA:94"
                },
                 new DeiceModel
                {
                    Name="Device 2",
                    DeviceID="A4:8C:91:EA:94"
                },
                  new DeiceModel
                {
                    Name="Device 3",
                    DeviceID="A4:8C:91:EA:94"
                },
                   new DeiceModel
                {
                    Name="Device 4",
                    DeviceID="A4:8C:91:EA:94"
                }
            };

        }

        private async void Connect_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Congig());
        }

        private void Device_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
          

           
           
            Connect.IsEnabled = true;
            Connect.BackgroundColor = Color.Green;
            Connect.Text = "Connect";
        }





    }
}