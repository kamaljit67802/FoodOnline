namespace FoodOnline;
using FoodOnline.Login;
using FoodOnline.Services;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        DependencyService.Register<FoodDataStoreAPI>();
        DependencyService.Register<WebClientService>();


        MainPage = new AppShell();
    }
}

