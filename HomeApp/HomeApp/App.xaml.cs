using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HomeApp.Pages;

namespace HomeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new ClimatePage();
            //MainPage = new PaddingPage();
            //MainPage = new NewDevicePage();
            //MainPage = new DeviceControlPage();
            MainPage = new AlarmPage();
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
