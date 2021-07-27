using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Singleton
{
    public partial class App : Application
    {
        Global global = Global.Instance();
        public App()
        {
            InitializeComponent();
            global.test = "Estamos Utilizando Modelo Singleton";
            MainPage = new PageWelcome();
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
