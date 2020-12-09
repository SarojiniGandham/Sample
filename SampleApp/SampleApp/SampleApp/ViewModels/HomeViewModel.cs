using SampleApp.Models;
using SampleApp.Services;
using SampleApp.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SampleApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        readonly IRecipeServices recipeServices;
        #region Constructor
        public HomeViewModel(IRecipeServices _recipeServices)
        {
            recipeServices = _recipeServices;
            LoadAllRecipes();
        }
        #endregion
        #region Properties
        ObservableCollection<RecipesModel> _allRecipes;
        public ObservableCollection<RecipesModel> AllRecipes
        {
            get
            {
                return _allRecipes;
            }
            set
            {
                _allRecipes = value;
                RaisePropertyChanged(() => AllRecipes);
            }
        }
        #endregion
        #region Command
        public ICommand LoadAllRecipesCommand => new Command(() => LoadAllRecipes());

        private void LoadAllRecipes()
        {
            //Need to handle api response BL logic here
            AllRecipes = recipeServices.GetRecipesData();
        }

        public void OnViewAppearing()
        {
            //to do
        }
        #endregion
    }
}
