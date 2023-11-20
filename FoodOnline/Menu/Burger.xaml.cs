namespace FoodOnline.Menu;
using FoodOnline.Models;
public partial class Burger : ContentPage
{
	public Burger()
	{
		InitializeComponent();


    }


    private void OnLabelNameTapped(object sender, EventArgs e)
    {
        if (sender is Label label && label.BindingContext is Category selectedCategory)
        {
            // Handle the tap event, and you have access to the selected category (selectedCategory)
            // For example, you can navigate to a new page with the selected category
            Navigation.PushAsync(new BurgerDetails(selectedCategory));
        }
    }
    private void OnDisableBackButtonClicked(object sender, EventArgs e)
    {
        NavigationPage.SetHasBackButton(this, false);
    }
}
