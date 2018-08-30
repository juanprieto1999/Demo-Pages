using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Demo1
{
    public partial class Page4 : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();

        }

        public Page4()
        {
            InitializeComponent();

        }
    }
}
