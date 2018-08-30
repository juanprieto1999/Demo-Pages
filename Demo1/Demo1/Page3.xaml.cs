using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Demo1
{
    public partial class Page3 : ContentPage
    {
        private async void BtnInicio_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void BtnAtras_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void BtnModal_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Page4()); 
        }
        public Page3()
        {
            InitializeComponent();
        }

    }
}
