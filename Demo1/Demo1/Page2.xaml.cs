using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Demo1
{
    public partial class Page2 : ContentPage
    {
        private async void Btn_Tres(object sender, System.EventArgs e)
        {
            this.lbOpcion.Text=string.Empty
                
                await Navigation.PushAsync(new Page3());
        }

        public Page2()
        {
            InitializeComponent();
        }
    }
}
