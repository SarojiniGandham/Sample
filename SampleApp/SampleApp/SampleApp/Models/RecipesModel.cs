using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.Models
{
    public class RecipesModel: BaseModel
    {
        private RecipesDTO item;

        public string ItemName { get; set; }
        public string Day { get; set; }
        public string Article { get; set; }
        public string ItemImage { get; set; }
        public string Title { get; set; }
        //public RecipesModel(RecipesDTO item)
        //{
        //    this.item = item;
        //}
    }
}
