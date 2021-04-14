using System;
using AnimeNorth.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("icons.ttf", Alias = "ANIcons")]
namespace AnimeNorth
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var nav = new NavigationPage(new Home());
            MainPage = nav;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
