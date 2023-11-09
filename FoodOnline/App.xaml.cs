namespace FoodOnline;
using FoodOnline.Login;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new Welcome();
    }
}

