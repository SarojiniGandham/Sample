// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.Models
{
    public class Nbsp
    {
        public string quantity { get; set; }
        public string unit { get; set; }
        public string name { get; set; }
        public string recipe_prefix { get; set; }
        public int serving_id { get; set; }
        public int product_id { get; set; }
    }

    public class Sauce
    {
        public string quantity { get; set; }
        public string unit { get; set; }
        public string name { get; set; }
        public string recipe_prefix { get; set; }
        public int serving_id { get; set; }
        public int product_id { get; set; }
    }

    public class Ingredients
    {
        public List<Nbsp> Nbsp { get; set; }
        public List<Sauce> Sauce { get; set; }
    }

    public class MealType
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string featured_image { get; set; }
    }

    public class MetaData
    {
        public string meta_ref { get; set; }
        public string meta_title { get; set; }
        public string meta_description { get; set; }
        public string meta_keywords { get; set; }
    }

    public class RecipesDTO
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("slug")]
        public string slug { get; set; }
        [JsonProperty("procedures")]
        public string procedures { get; set; }
        [JsonProperty("serving_number")]
        public string serving_number { get; set; }
        [JsonProperty("serving_cost")]
        public string serving_cost { get; set; }
        [JsonProperty("budget_range")]
        public string budget_range { get; set; }
        [JsonProperty("preparation_time")]
        public string preparation_time { get; set; }
        [JsonProperty("cooking_time")]
        public string cooking_time { get; set; }
        public string thumbnail_image { get; set; }
        public string thumbnail_image_tag { get; set; }
        public string featured_image { get; set; }
        public string featured_image_tag { get; set; }
        public string excerpt { get; set; }
        public string chef_tip { get; set; }
        public string lusog_note { get; set; }
        public string created { get; set; }
        public int best_product_id { get; set; }
        public string best_product_name { get; set; }
        public string best_product_slug { get; set; }
        public string best_product_image { get; set; }
        public string best_product_thumbnail_image { get; set; }
        public int best_product_parent_category_id { get; set; }
        public string best_product_parent_category_name { get; set; }
        public string best_product_parent_category_slug { get; set; }
        public int is_recipe_of_the_day { get; set; }
        public List<object> cooking_skills { get; set; }
        public List<object> cooking_tools { get; set; }
        public Ingredients ingredients { get; set; }
        public List<MealType> meal_type { get; set; }
        public MetaData meta_data { get; set; }
        public string average_rating { get; set; }
        public int total_rating_count { get; set; }
    }

    //public class RecipesDTO
    //{
    //    [JsonProperty("items")]
    //    public List<Item> items { get; set; }
    //}

}