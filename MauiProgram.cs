using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Toppers_Pizza.Services;
using Toppers_Pizza.ViewModels;
using Toppers_Pizza.Pages;
namespace Toppers_Pizza;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.UseMauiCommunityToolkit();

#if DEBUG
        builder.Logging.AddDebug();
#endif
		AddPizzaServices(builder.Services);

		return builder.Build();
	}
	private static IServiceCollection
		AddPizzaServices(IServiceCollection services)
	{
		services.AddSingleton<PizzaService>();
		services.AddSingleton<HomePage>().AddSingleton<HomeViewModel>();
		//services.AddSingletonWithShellRoute<HomePage, HomeViewModel>(nameof(HomePage));
		services.AddTransientWithShellRoute<AllPizzaPage, AllPizzaViewModel>(nameof(AllPizzaPage));
        services.AddTransientWithShellRoute<DetailPage, DetailsViewModel>(nameof(DetailPage));
		services.AddSingleton<CartViewModel>();
		services.AddTransient<CartPage>();
        return services;
	}
}

