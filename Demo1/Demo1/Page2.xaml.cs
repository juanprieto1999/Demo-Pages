using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Demo1
{
    public partial class Page2 : ContentPage
    {
        private async void BtnTres_Clicked(object sender, System.EventArgs e)
        {
            this.lbOpcion.Text = string.Empty;
                
                await Navigation.PushAsync(new Page3());
        }

        private async void BtnTets_Clicked(object sender, System.EventArgs e)
        {
            this.lbOpcion.Text = string.Empty;


                var resp = await DisplayAlert("Test", "Esta seguro de realizar el test", "Si","No");
            if(resp)
            {
                await DisplayAlert("Inicio de test", "Bienvenido", "Aceptar");
                var opcion = await DisplayActionSheet("Opciones", "Cancelar", null, "Opciion1", "Opcion 2", "Opcion 3");
                lbOpcion.Text = opcion.ToString();
            }
            else
            {
                await DisplayAlert("Test Fallido", "En otra ocasion sera", "Aceptar");
            }

        }

        public Page2()
        {
            InitializeComponent();
        }
    }
}
