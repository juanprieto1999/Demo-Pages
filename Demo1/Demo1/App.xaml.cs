using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Demo1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new DemoCarousel();
            //MainPage = new NavigationPage(new DemoCarousel());
           //var navigetionpage = new NavigationPage(new DemoNavigationPage());
           // navigetionpage.BarBackgroundColor = Color.Blue;
            //navigetionpage.BarTextColor = Color.White;
           // MainPage = navigetionpage;


        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
