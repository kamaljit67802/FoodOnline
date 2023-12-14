﻿using System;
using CommunityToolkit.Mvvm.Input;

namespace Toppers_Pizza.ViewModels
{
	[QueryProperty(nameof(FromSearch),nameof(FromSearch))]
	public  partial class AllPizzaViewModel : ObservableObject
	{

		private readonly PizzaService _pizzaService;

public AllPizzaViewModel(PizzaService pizzaService)
		{
			_pizzaService = pizzaService;
			Pizzas = new(_pizzaService.GetAllPizzas());
		}
		public ObservableCollection<Pizza> Pizzas { get; set; }

		[ObservableProperty]
		private bool _fromSearch;

		[ObservableProperty]
		private bool _searching;


		[RelayCommand]
		private async Task SearchPizzas(string searchTerm)
		{
			Pizzas.Clear();
			Searching = true;
			await Task.Delay(2000);
			foreach (var pizzas in _pizzaService.SearchPizzas(searchTerm))
			{
				Pizzas.Add(pizzas);
			}
			Searching = false;
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

