using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartController
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           

        }

        private async void  TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());

        }
    }
}
