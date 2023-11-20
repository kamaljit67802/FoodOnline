using System;
using FoodOnline.Models;
using System.Dynamic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;



namespace FoodOnline.Services
{


    class FoodDataStoreAPI : IFoodDataStore<Category>
    {
        string strMyCate = MainPage.strmyCat;
        private string API = "https://forkify-api.herokuapp.com/api/search?q=hamburger";

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            if (MainPage.strmyCat is "Burger")
            {
                API = "https://forkify-api.herokuapp.com/api/search?q=hamburger";

                strMyCate = "";

            }
            else if (MainPage.strmyCat is "Pizza")
            {
                API = "https://forkify-api.herokuapp.com/api/search?q=pizza";

                strMyCate = "";



            }
            else if (MainPage.strmyCat is "Dessert")
            {
                API = "https://forkify-api.herokuapp.com/api/search?q=ice cream";


                strMyCate = "";


            }
            else
            {
                API = "https://forkify-api.herokuapp.com/api/search?q=chocolate";

                strMyCate = "";



            }
            var service = DependencyService.Get<IWebClientService>();
            var json = await service.GetAsync($"{API}");

            var newsData = FoodBuilder(json);

            return newsData;
        }
        private List<Category> FoodBuilder(string json)
        {

            var response = JsonConvert.DeserializeObject<dynamic>(json);
            var users = response.recipes;

            var mynews = new List<Category>();

            foreach (var user in users)
            {
                var title = user.title.ToString();
                var str = user.title.ToString();
                var urlToImage = user.image_url.ToString();

                mynews.Add(new Category(title, str, urlToImage));


            }

            return mynews;
        }

        public static class UserBuilder
        {

        }
    }
}




