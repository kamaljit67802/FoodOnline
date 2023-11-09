namespace FoodOnline.Login;

public partial class Welcome : ContentPage
{
    public Welcome()
    {
        InitializeComponent();
    }

    private async void OnMySignUpClicked(object sender, EventArgs e)
    {       

        App.Current.MainPage = new NavigationPage(new SignUp());


    }

    void OnMyLoginClicked(System.Object sender, System.EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new Login());

    }
}

