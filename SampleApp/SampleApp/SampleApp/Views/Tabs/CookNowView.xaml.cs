using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp.Views.Tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CookNowView : ContentPage
    {
        public CookNowView()
        {
            InitializeComponent();
        }
        public void TabAppearing()
        {
            //to do
        }
    }
}