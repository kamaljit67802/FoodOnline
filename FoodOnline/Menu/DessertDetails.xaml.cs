namespace FoodOnline.Menu;
using FoodOnline.Models;
using FoodOnline.Menu;

public partial class DessertDetails : ContentPage
{

    public DessertDetails(Category selectedItem)
    {
        InitializeComponent();
        UpdateUI(selectedItem);

    }
    private void UpdateUI(Category selectedItem)
    {
        myDessertName.Text = selectedItem.Name; // Assuming you have a Title property in your Category class
        myDessertDetails.Text = selectedItem.Name;
        AddToSelectedItems(selectedItem);
    }
    private static void AddToSelectedItems(Category selectedItem)
    {
        BurgerDetails.selectedItems.Add(selectedItem);
    }


    private async void OnAddMeToCart(object sender, EventArgs e)
    {

        DisplayAlert("Selected Items", $"Total selected items: {BurgerDetails.selectedItems.Count}", "OK");
        Preferences.Default.Remove("Category");

        Navigation.PushAsync(new MainPage());


    }
}
