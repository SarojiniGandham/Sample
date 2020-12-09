using Newtonsoft.Json;
using SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;

namespace SampleApp.Services
{
    public class RecipeService : IRecipeServices
    {
        public ObservableCollection<RecipesModel> GetRecipesData()
        {
            //It will be useful api url and json file is available :)
            //string jsonFileName = "recipes.json";
            //var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            //Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
            //using (var reader = new System.IO.StreamReader(stream))
            //{
            //    var jsonString = reader.ReadToEnd();

            //    Converting JSON Array Objects into generic list
            //    var recipes = JsonConvert.DeserializeObject<ObservableCollection<RecipesDTO>>(jsonString);

            //    var recipeslist = new ObservableCollection<RecipesModel>();
            //    foreach (var item in recipes)
            //    {
            //        recipeslist.Add(new RecipesModel(item));
            //    }
            //    return recipeslist;
            //}
            //Hard coded services
            var serviceResponse = new ObservableCollection<RecipesModel>()
            {
                new RecipesModel{ItemImage="ic_itemone",ItemName="Pancit palabok",Article="lesson1",Day="Monday",Title="How to make a @@@@@"},
                new RecipesModel{ItemImage="ic_itemthree",ItemName="Tab ng talangka",Article="lesson1",Day="Tuesday",Title="How to make a @@@@@"},
                new RecipesModel{ItemImage="ic_itemfour",ItemName="Pancit palabok",Article="lesson1",Day="Monday",Title="How to make a @@@@@"},
                new RecipesModel{ItemImage="ic_itemfive",ItemName="Tab ng talangka",Article="lesson1",Day="Tuesday",Title="How to make a @@@@@"},
                new RecipesModel{ItemImage="ic_itemtwo",ItemName="Pancit palabok",Article="lesson1",Day="Monday",Title="How to make a @@@@@"},
                new RecipesModel{ItemImage="ic_itemthree",ItemName="Tab ng talangka",Article="lesson1",Day="Tuesday",Title="How to make a @@@@@"},
                new RecipesModel{ItemImage="ic_itemone",ItemName="Pancit palabok",Article="lesson1",Day="Monday",Title="How to make a @@@@@"},
                new RecipesModel{ItemImage="ic_itemthree",ItemName="Tab ng talangka",Article="lesson1",Day="Tuesday",Title="How to make a @@@@@"},
                new RecipesModel{ItemImage="ic_itemfour",ItemName="Pancit palabok",Article="lesson1",Day="Monday",Title="How to make a @@@@@"},
                new RecipesModel{ItemImage="ic_itemfive",ItemName="Tab ng talangka",Article="lesson1",Day="Tuesday",Title="How to make a @@@@@"},
            };
            return serviceResponse;
        }
    }
}
