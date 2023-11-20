namespace FoodOnline.Menu;
using FoodOnline.Models;

public partial class BurgerDetails : ContentPage
{
    public static List<Category> selectedItems { get; } = new List<Category>();

    public BurgerDetails(Category selectedItem)
	{
		InitializeComponent();
        UpdateUI(selectedItem);

    }
    private void UpdateUI(Category selectedItem)
    {
        titleLabel.Text = selectedItem.Name; // Assuming you have a Title property in your Category class
        descriptionLabel.Text = selectedItem.Name;
        AddToSelectedItems(selectedItem);
    }
    private static void AddToSelectedItems(Category selectedItem)
    {
        selectedItems.Add(selectedItem);
    }


    private async void OnAddToCart(object sender, EventArgs e)
    {

        DisplayAlert("Selected Items", $"Total selected items: {selectedItems.Count}", "OK");
        Preferences.Default.Remove("Category");

        Navigation.PushAsync(new MainPage());



    }
}
