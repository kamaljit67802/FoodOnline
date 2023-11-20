using System;
using FoodOnline.Services;
using FoodOnline.Models;
using MvvmHelpers;
using MvvmHelpers.Commands;

namespace FoodOnline.ViewModels
{
    //https://devblogs.microsoft.com/dotnet/introducing-the-net-maui-community-toolkit-preview/#what-to-expect-in-net-maui-toolkit

    internal class FoodListViewModel 
    {

        public IFoodDataStore<Category> DataStore =>
            DependencyService.Get<IFoodDataStore<Category>>();

        public ObservableRangeCollection<Category> cat{ get; set; }

        public AsyncCommand PageAppearingCommand { get; }


        public FoodListViewModel()
        {
            cat = new ObservableRangeCollection<Category>();
            PageAppearingCommand = new AsyncCommand(PageAppearing);
        }

        public async Task Refresh()
        {
             var catt = await DataStore.GetCategoriesAsync();

            cat.AddRange(catt);
        }

        async Task PageAppearing()
        {
            await Refresh();
        }
    }
}

