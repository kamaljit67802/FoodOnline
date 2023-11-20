using FoodOnline.Models;
namespace FoodOnline.Menu;

public partial class PizzaDetails : ContentPage
{

    public PizzaDetails(Category selectedItem)
    {
        InitializeComponent();
        UpdateUI(selectedItem);

    }
    private void UpdateUI(Category selectedItem)
    {
        myPizzaName.Text = selectedItem.Name; // Assuming you have a Title property in your Category class
        myPizzaDetails.Text = selectedItem.Name;
        AddToSelectedItems(selectedItem);
    }
    private static void AddToSelectedItems(Category selectedItem)
    {
        BurgerDetails.selectedItems.Add(selectedItem);
    }


    private async void OnPizzaToCart(object sender, EventArgs e)
    {

        DisplayAlert("Selected Items", $"Total selected items: {BurgerDetails.selectedItems.Count}", "OK");
        Preferences.Default.Remove("Category");

        Navigation.PushAsync(new MainPage());



    }
}


