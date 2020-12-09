using SampleApp.ViewModels;
using SampleApp.ViewModels.Shared;
using SampleApp.Views.Shared;
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
    public partial class TabsView : BaseView
    {
        TabsViewModel viewModel;
        public TabsView()
        {
            InitializeComponent();
            viewModel = BindingContext as TabsViewModel;
        }
    }
}