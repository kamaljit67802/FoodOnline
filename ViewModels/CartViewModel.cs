namespace Toppers_Pizza.ViewModels
{
    public partial class CartViewModel : ObservableObject
	{
		public event EventHandler<Pizza> CartItemRemove;
		public event EventHandler CartCleared;
		public ObservableCollection<Pizza> Items { get; set; } = new();

		[ObservableProperty]
		private double _totalAmount;

		private void RecalculateTotalAmount() => TotalAmount = Items.Sum(i => i.Amount);


		[RelayCommand]
		private void UpdateCartItem(Pizza pizza)
		{
            var item = Items.FirstOrDefault(i=> i.Name == pizza.Name);
			if(item is not null)
					{ 
				item.CartQuantity = pizza.CartQuantity;


			}
			else
			{
				Items.Add(pizza.Clone());
			}
			RecalculateTotalAmount();
		}
		[RelayCommand]
		private void RemoveCartItem(string name)
		{
            var item = Items.FirstOrDefault(i => i.Name == name);

	
            if (item is not null)
            {
				Items.Remove(item);
				RecalculateTotalAmount();
				CartItemRemove?.Invoke(this, item);


			}
			else
			{
                 Shell.Current.GoToAsync("..", animate: true);
            }
            
        }
		[RelayCommand]
		private async void ClearCart()
		{
			if (await Shell.Current.DisplayAlert("Please Don't clear me", "Are you sure want to clear", "Yes Clear me", "No Please not"))

			{
                Items.Clear();
                RecalculateTotalAmount();
                CartCleared?.Invoke(this, EventArgs.Empty);

                await Toast.Make("I am Empty Now", ToastDuration.Short).Show();
                await Shell.Current.GoToAsync("..", animate: true);

            }

        }
		[RelayCommand]
		private async Task PlaceOrder()
		{
			Items.Clear();
            CartCleared?.Invoke(this, EventArgs.Empty);
            RecalculateTotalAmount();
			await Shell.Current.GoToAsync(nameof(CheckoutPage), animate: true);
		}
	}
}

