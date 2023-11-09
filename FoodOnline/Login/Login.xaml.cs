namespace FoodOnline.Login;
public partial class Login : ContentPage
{
    public Login()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Add your own logic for authenticating the user
        if (!string.IsNullOrEmpty(EmailEntry.Text) && !string.IsNullOrEmpty(PasswordEntry.Text))
        {
            await Navigation.PushAsync(new MainPage());
        }
        else
        {
            await DisplayAlert("Error", "Email and password fields cannot be empty.", "OK");
        }
    }

}