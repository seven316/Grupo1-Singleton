using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Singleton
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageWelcome : ContentPage
    {
        public PageWelcome()
        {
            InitializeComponent();
            Global global = Global.Instance();
            DisplayAlert("Alert", global.test, "OK");
        }
    }
}