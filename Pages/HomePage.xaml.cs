namespace Toppers_Pizza.Pages;

public partial class HomePage : ContentPage
{

	private readonly HomeViewModel _homeViewModel;

	public HomePage(HomeViewModel homeViewModel)
	{
        _homeViewModel = homeViewModel;
        InitializeComponent();
		
		BindingContext = _homeViewModel;

	}
}
