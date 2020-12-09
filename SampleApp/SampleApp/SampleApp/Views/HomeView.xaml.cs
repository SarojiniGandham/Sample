using SampleApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {
        HomeViewModel homeViewModel;
        public HomeView()
        {
            InitializeComponent();
            homeViewModel = BindingContext as HomeViewModel;
        }
        public void TabAppearing()
        {
            homeViewModel.OnViewAppearing();
        }
    }
}