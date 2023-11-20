using System.Collections.ObjectModel;
using FoodOnline.Menu;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
namespace FoodOnline;
public partial class MainPage : ContentPage
{
public static string strmyCat = "";
    public MainPage()
    {
        InitializeComponent();


    }

    private async void OnBurgerClicked(object sender, EventArgs e)
        {
        // Add your own logic for authenticating the user
        strmyCat = "Burger";
        await Navigation.PushAsync(new Burger());
            }
           
        

        private async void OnPizzaClicked(object sender, EventArgs e)
{
        strmyCat = "Pizza";

        Navigation.PushAsync(new Pizza());
}
           
        

        private async void OnDessertClicked(object sender, EventArgs e)
        
    
    {
        strmyCat ="Dessert";


        Navigation.PushAsync(new Dessert());
    }


        

        private async void OnSoupClicked(object sender, EventArgs e)
            {

        // Add your own logic for authenticating the user
        strmyCat = "Soup";

        Navigation.PushAsync(new Soup());
}
           
        
        //    BindingContext = this;

        //    Items = new ObservableCollection<Item>
        //        {
        //        new Item { ImageSource = "burgers.png", LabelText = "Label 1" },
        //        new Item { ImageSource = "desserts.png", LabelText = "Label 2" },
        //        new Item { ImageSource = "drinks.png", LabelText = "Label 3" },
        //        new Item { ImageSource = "nonveg.png", LabelText = "Label 4" },
        //        new Item { ImageSource = "pizza.png", LabelText = "Label 5" },
        //        new Item { ImageSource = "veg.png", LabelText = "Label 6" },
        //       // ... more items here
        //        };
        //}

        //private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
        //    {
        //        var item = e.CurrentSelection[0] as Item;
        //        Navigation.PushAsync(new Burger());
        //        ((CollectionView)sender).SelectedItem = null;
        //    }
        //}

        //private void OnGoToSecondPageClicked(object sender, System.EventArgs e)
        //{
        //    Navigation.PushAsync(new Burger());
        //}


        //public class Item
        //{
        //    public string ImageSource { get; set; }
        //    public string LabelText { get; set; }
        //}
    
}
