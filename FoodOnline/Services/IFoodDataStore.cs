using System;
using FoodOnline.Models;




namespace FoodOnline.Services
{
    interface IFoodDataStore<T>
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
        
    }
}

