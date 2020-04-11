using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TestXamForms20200411.Services;
using TestXamForms20200411.Views;

namespace TestXamForms20200411
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
