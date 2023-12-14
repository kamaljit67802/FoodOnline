

namespace Toppers_Pizza.ViewModels
{
	public partial class HomeViewModel : ObservableObject
	{
		public readonly PizzaService _pizzaService;
		public HomeViewModel(PizzaService pizzaService)
		{
			_pizzaService = pizzaService;
			Pizzas = new(_pizzaService.GetPopularPizzas());
		}

		public ObservableCollection<Pizza> Pizzas { get; set; }


		[RelayCommand]
		private async Task GoToAllPizzaPage(bool fromSearch)
		{
			var parameter = new Dictionary<string, object>
			{
				[nameof(AllPizzaViewModel.FromSearch)] = fromSearch
			};
			await Shell.Current.GoToAsync(nameof(AllPizzaPage), animate: true, parameter);
		}

		[RelayCommand]
		private async Task GoToDetailsPage(Pizza pizza)
		{
            var parameter = new Dictionary<string, object>
            {
                [nameof(DetailsViewModel.Pizza)] = pizza
            };
            await Shell.Current.GoToAsync(nameof(DetailPage), animate: true, parameter);

	}
	}
}

