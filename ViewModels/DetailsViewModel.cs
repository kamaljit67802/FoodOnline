
namespace Toppers_Pizza.ViewModels
{

	[QueryProperty(nameof(Pizza), nameof(Pizza))]
	public partial class DetailsViewModel : ObservableObject , IDisposable
	{
		private readonly CartViewModel _cartViewModel;
		public DetailsViewModel(CartViewModel cartViewModel)
		{
			_cartViewModel = cartViewModel;
			_cartViewModel.CartCleared += OnCartCleared;
			_cartViewModel.CartItemRemove += OnCartItemRemoved;

		}
		private void OnCartCleared(object? sender , EventArgs e) => Pizza.CartQuantity = 0;
		private void OnCartItemRemoved(object? _, Pizza p) => OnCartItemChanged(p,0);

		private void OnCartItemChanged(Pizza p,int quantity)
		{
			if(p.Name == Pizza.Name)
			{
				Pizza.CartQuantity = quantity;
			}
		}

        [ObservableProperty]
		private Pizza _pizza;

		[RelayCommand]
		private void AddToCart()
		{

            if (Pizza != null && _cartViewModel != null)
            {
                Pizza.CartQuantity++;
                _cartViewModel.UpdateCartItemCommand.Execute(Pizza);
            }
        }
        [RelayCommand]
        private void RemoveFromCart()
        {
			if(Pizza.CartQuantity > 0 )
			{
				Pizza.CartQuantity--;
                _cartViewModel.UpdateCartItemCommand.Execute(Pizza);

            }
        }
		[RelayCommand]
		private async Task ViewCart()
		{
			if ( Pizza.CartQuantity > 0)
			{
				await Shell.Current.GoToAsync(nameof(CartPage), animate: true);
			}else
			{
				await Toast.Make("Please select atlease one Item", ToastDuration.Short).Show();

			}
		}

        public void Dispose()
        {
            _cartViewModel.CartCleared -= OnCartCleared;
            _cartViewModel.CartItemRemove -= OnCartItemRemoved;
        }
    }
}

