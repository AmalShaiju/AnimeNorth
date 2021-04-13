using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimeNorth
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            var nav = new NavigationPage(new Page());
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
