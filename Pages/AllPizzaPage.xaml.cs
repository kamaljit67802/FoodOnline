namespace Toppers_Pizza.Pages;

public partial class AllPizzaPage : ContentPage
{
	private readonly AllPizzaViewModel _allPizzaViewModel1;
	public AllPizzaPage(AllPizzaViewModel allPizzaViewModel)
	{
		InitializeComponent();
		_allPizzaViewModel1 = allPizzaViewModel;
		BindingContext = _allPizzaViewModel1;

	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
		if(_allPizzaViewModel1.FromSearch)
		{
            await Task.Delay(1000);
			searchBar.Focus();
		}
    }
    void searchBar_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
		if(!string.IsNullOrWhiteSpace(e.OldTextValue) && string.IsNullOrWhiteSpace(e.NewTextValue))
				{
			_allPizzaViewModel1.SearchPizzasCommand.Execute(null); 
		}
    }
}
