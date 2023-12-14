namespace Toppers_Pizza.Pages;

public partial class DetailPage : ContentPage
{
    private readonly DetailsViewModel _detailsViewModel;
    public DetailPage(DetailsViewModel detailsViewModel)
    {
        InitializeComponent();
        _detailsViewModel = detailsViewModel;
        BindingContext = _detailsViewModel;

    }

   async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync("..", animate: true);

    }
}
