using SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SampleApp.Services
{
    public interface IRecipeServices
    {
        ObservableCollection<RecipesModel> GetRecipesData();
    }
}
