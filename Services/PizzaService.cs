using System;
using Toppers_Pizza.Models;
namespace Toppers_Pizza.Services
{
	public class PizzaService
	{
		private readonly static IEnumerable<Pizza> _pizzas = new List<Pizza>
			{
			new Pizza
			{
				Name = "Pepproni Pizza",
				Image = "peproni",
				Price = 15.50,
                Rating = "5",
                Description="A classic favourite, plain and simple, which includes pepperoni as a topping on the whole pizza. \n\n(150 – 520 Cals/Slice)"

            },

            new Pizza
            {
                Name = "Delux Pizza",
                Image = "peproni.png",
                Price =23,
                Rating = "5",
                Description="For pizza lover’s who love toppings. White onions, mushrooms, green peppers, bacon, pepperoni, and mozzarella cheese.\n\n(220-290 Cals/Slice) "

            },

            new Pizza
            {
                Name = "Honey Ham Pizza",
                Image = "peproni",
                Price = 25.50,
                Rating = "5",
                Description="Our authentic crust, loaded with extra ham, mozzarella cheese, and our sweet & savoury honey garlic sauce. Available for a limited time. "

            },

            new Pizza
            {
                Name = "Pepproni Explosion",
                Image = "peproni",
                Price = 9.50,
                Rating = "4.3",
                Description="Topped with extra mozzarella, pepperoni and Roni cups – the latest trend in premium pepperoni. Once baked, these pepperoni slices crisp up perfectly for an amazing crunch!"

            },

            new Pizza
            {
                Name = "Margerita Pizza",
                Image = "margerita",
                Price = 10.0,
                Rating = "3",
                 Description="Aromatic and full of flavour. Thin crust, brushed with 100% extra virgin olive oil, mozzarella cheese, hand-torn basil, and Parmesan cheese. \n\n(180-230 Cals/Slice)"
            },

            new Pizza
            {
                Name = "Canadian Pizza",
                Image = "canadiana",
                Price = 18.50,
                Rating = "4.5",
                 Description="Canada’s most beloved pizza. Mozzarella and cheddar cheese, bacon, mushrooms, and pepperoni. Delicious, eh?\n\n(220-290 Cals/Slice) "
            },

            new Pizza
            {
                Name = "Meat Lover Pizza",
                Image = "meat",
                Price = 25.50,
                                Rating = "4.9",
                 Description="The meat lover’s pizza! Loaded with a “mountain” of pepperoni, ham, bacon, ground beef, Italian sausage, and mozzarella. Hope you’re hungry!\n\n(240-320 Cals/Slice)"

            },

            new Pizza
            {
                Name = "Double Burger Pizza",
                Image = "peproni",
                Price = 12.50,
                                Rating = "4.3",
                                 Description=""

            },

            new Pizza
            {
                Name = "Veggie Pizza",
                Image = "veggie",
                Price = 17.50,
                                Rating = "3.7",
                                 Description="Eat your veggies! Tomatoes, green peppers, mushrooms, white onions, green olives, and mozzarella cheese. Amp it up by adding a Ranch Swirl!\n\n(190-250 Cals/Slice)"

            },

            new Pizza
            {
                Name = "Cheez Pizza",
                Image = "slice",
                Price = 10.50,
                                Rating = "3.7"
                , Description="Includes Sauce & Cheese.\n\n(150 – 520 Cals/Slice)"

            },

            new Pizza
            {
                Name = "Buffalo Chicken Pizza",
                Image = "peproni",
                Price = 27.50,
                                Rating = "4.1",
                                 Description="Medium wing sauce, tender breaded chicken tossed in medium wing sauce, red onions, roasted red peppers and a swirl of Ranch dip.\n\n(240-300 Cals/Slice) "


            },

            new Pizza
            {
                Name = "Build Your Own Pizza",
                Image = "veggie",
                Price = 15.50,
                                Rating = "4.6",
                                 Description=""

            },

            new Pizza
            {
                Name = "Eight Topper Pizza",
                Image = "margerita",
                Price = 22.50,
                Rating = "3.8",
                 Description="Featuring eight of our most popular toppings: Pepperoni, mushrooms, green peppers, onions, Italian sausage, green olives, ham, and bacon. "

            }
            };

        public IEnumerable<Pizza> GetAllPizzas() => _pizzas;

        public IEnumerable<Pizza> GetPopularPizzas(int count = 6) =>
            _pizzas.OrderBy(p => Guid.NewGuid())
            .Take(count);

        public IEnumerable<Pizza> SearchPizzas(string searchTerm) => string.IsNullOrWhiteSpace(searchTerm)
            ? _pizzas
            : _pizzas.Where(p => p.Name.Contains (searchTerm, StringComparison.OrdinalIgnoreCase));
    }
}

