using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo1
{
    public partial class MainPage : ContentPage
    {
        void Btn1_Clicked(object sender, System.EventArgs e)
        {
            //Agregar Boton a Xamal
            Panel.Children.Add(new Button()
            {
                Text = $"Boton{Panel.Children.Count +1}"
            });
        }
         
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
