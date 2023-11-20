namespace FoodOnline.Menu;

using FoodOnline.Models;
using FoodOnline.Menu;

public partial class SoupDetails : ContentPage
{

    public SoupDetails(Category selectedItem)
    {
        InitializeComponent();
        UpdateUI(selectedItem);

    }
    private void UpdateUI(Category selectedItem)
    {
        mySoupName.Text = selectedItem.Name;
        mySoupNameDetails.Text = selectedItem.Name;
        AddToSelectedItems(selectedItem);
    }
    private static void AddToSelectedItems(Category selectedItem)
    {
        BurgerDetails.selectedItems.Add(selectedItem);
    }


    private async void OnSoupToCart(object sender, EventArgs e)
    {

        DisplayAlert("Selected Items", $"Total selected items: {BurgerDetails.selectedItems.Count}", "OK");
        Preferences.Default.Remove("Category");

        Navigation.PushAsync(new MainPage());



    }
}
