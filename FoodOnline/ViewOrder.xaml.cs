namespace FoodOnline;
using FoodOnline.Menu;

public partial class ViewOrder : ContentPage
{
    public bool IsSelectedItemsEmpty => BurgerDetails.selectedItems.Count == 0;

    public ViewOrder()
	{
		InitializeComponent();
        selectedItemsCollectionView.ItemsSource = BurgerDetails.selectedItems;

}

void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        DisplayAlert("On the Way...!!!!", "Your order is Placed", "OK");
        BurgerDetails.selectedItems.Clear();



    }
}
