namespace FoodOnline.Login;

public partial class SignUp : ContentPage
{

    public SignUp()
    {
        InitializeComponent();
    }


    private async void OnSignupClicked(object sender, EventArgs e)
    {
        // Add your own logic for signing up the user
        if (!string.IsNullOrEmpty(NameEntry.Text) && !string.IsNullOrEmpty(EmailEntry.Text) && !string.IsNullOrEmpty(PasswordEntry.Text))
        {
            await Navigation.PushAsync(new Login());
        }
        else
        {
            await DisplayAlert("Error", "Name, email, and password fields cannot be empty.", "OK");
        }

    }

}