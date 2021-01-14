using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ListViewAppMVOP.Model;

namespace ListViewAppMVOP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListViewPageMan());
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
