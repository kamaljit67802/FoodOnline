
namespace FoodOnline.ViewModels;
using Models;

    public partial class MainViewModel
    {

    //private async Task SelectOfferAsync(Offer offer)
    //{
    //    await Shell.Current.DisplayAlert("Offer Tapped", $"Offer {offer} is selected. We will move to a new page for offer details", "Ok");
    //}

    private static IEnumerable<Category> LoadCategories()
    {
        return new List<Category>
        {
            new Category(1, "Burgers", "burgers.png"),
            new Category(2, "Desserts", "desserts.png"),
            new Category(3, "Drinks", "drinks.png"),
            new Category(4, "Non-Veg", "nonveg.png"),
            new Category(5, "Pizza", "pizza.png"),
            new Category(6, "Rice", "rice.png"),
            new Category(7, "Seafood", "seafood.png"),
            new Category(8, "Soups", "soups.png"),
            new Category(9, "Veg", "veg.png"),
        };
    }

}
