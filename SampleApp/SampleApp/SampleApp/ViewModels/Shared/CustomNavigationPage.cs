using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleApp.Shared
{
    public class CustomNavigationPage : NavigationPage
    {
        public CustomNavigationPage()
        {
            BarTextColor = Color.White;
        }
        public CustomNavigationPage(Page root) : base(root)
        {
            BarTextColor = Color.White;
        }
    }
}
