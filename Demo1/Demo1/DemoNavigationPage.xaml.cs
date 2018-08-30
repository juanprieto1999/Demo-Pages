using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Demo1
{
    public partial class DemoNavigationPage : ContentPage
    {
        private async void btn1_clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        public DemoNavigationPage()
        {
            InitializeComponent();
        }
    }
}
