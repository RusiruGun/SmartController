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
    public partial class Congig : ContentPage
    {
        public Congig()
        {
            InitializeComponent();
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            HouseNumber.IsEnabled = false;
            DiiceNumber.IsEnabled = false;

            ImageDone.IsVisible = true;



        }
    }
}