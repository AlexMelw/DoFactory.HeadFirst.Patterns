namespace DoFactory.HeadFirst.Composite.Menu
{
    using System;

    class MenuTestDrive
    {
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu
            {
                Name = "PANCAKE HOUSE MENU",
                Description = "Breakfast"
            };
            MenuComponent dinerMenu = new Menu
            {
                Name = "DINER MENU",
                Description = "Lunch"
            };
            MenuComponent cafeMenu = new Menu
            {
                Name = "CAFE MENU",
                Description = "Dinner"
            };
            MenuComponent dessertMenu = new Menu
            {
                Name = "DESSERT MENU",
                Description = "Dessert of course!"
            };
            MenuComponent coffeeMenu = new Menu
            {
                Name = "COFFEE MENU",
                Description = "Stuff to go with your afternoon coffee"
            };
            MenuComponent allMenus = new Menu
            {
                Name = "ALL MENUS",
                Description = "All menus combined"
            };

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            pancakeHouseMenu.Add(new MenuItem
            {
                Name = "K&B's Pancake Breakfast",
                Description = "Pancakes with scrambled eggs, and toast",
                Vegetarian = true,
                Price = 2.99
            });
            pancakeHouseMenu.Add(new MenuItem
            {
                Name = "Regular Pancake Breakfast",
                Description = "Pancakes with fried eggs, sausage",
                Vegetarian = false,
                Price = 2.99
            });
            pancakeHouseMenu.Add(new MenuItem
            {
                Name = "Blueberry Pancakes",
                Description = "Pancakes made with fresh blueberries, and blueberry syrup",
                Vegetarian = true,
                Price = 3.49
            });
            pancakeHouseMenu.Add(new MenuItem
            {
                Name = "Waffles",
                Description = "Waffles, with your choice of blueberries or strawberries",
                Vegetarian = true,
                Price = 3.59
            });

            dinerMenu.Add(new MenuItem
            {
                Name = "Vegetarian BLT",
                Description = "(Fakin') Bacon with lettuce & tomato on whole wheat",
                Vegetarian = true,
                Price = 2.99
            });
            ;
            dinerMenu.Add(new MenuItem
            {
                Name = "BLT",
                Description = "Bacon with lettuce & tomato on whole wheat",
                Vegetarian = false,
                Price = 2.99
            });
            dinerMenu.Add(new MenuItem
            {
                Name = "Soup of the day",
                Description = "A bowl of the soup of the day, with a side of potato salad",
                Vegetarian = false,
                Price = 3.29
            });
            dinerMenu.Add(new MenuItem
            {
                Name = "Hotdog",
                Description = "A hot dog, with saurkraut, relish, onions, topped with cheese",
                Vegetarian = false,
                Price = 3.05
            });
            dinerMenu.Add(new MenuItem
            {
                Name = "Steamed Veggies and Brown Rice",
                Description = "Steamed vegetables over brown rice",
                Vegetarian = true,
                Price = 3.99
            });
            dinerMenu.Add(new MenuItem
            {
                Name = "Pasta",
                Description = "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                Vegetarian = true,
                Price = 3.89
            });

            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem
            {
                Name = "Apple Pie",
                Description = "Apple pie with a flakey crust, topped with vanilla icecream",
                Vegetarian = true,
                Price = 1.59
            });
            dessertMenu.Add(new MenuItem
            {
                Name = "Cheesecake",
                Description = "Creamy New York cheesecake, with a chocolate graham crust",
                Vegetarian = true,
                Price = 1.99
            });
            dessertMenu.Add(new MenuItem
            {
                Name = "Sorbet",
                Description = "A scoop of raspberry and a scoop of lime",
                Vegetarian = true,
                Price = 1.89
            });
            cafeMenu.Add(new MenuItem
            {
                Name = "Veggie Burger and Air Fries",
                Description = "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                Vegetarian = true,
                Price = 3.99
            });
            cafeMenu.Add(new MenuItem
            {
                Name = "Soup of the day",
                Description = "A cup of the soup of the day, with a side salad",
                Vegetarian = false,
                Price = 3.69
            });
            cafeMenu.Add(new MenuItem
            {
                Name = "Burrito",
                Description = "A large burrito, with whole pinto beans, salsa, guacamole",
                Vegetarian = true,
                Price = 4.29
            });

            cafeMenu.Add(coffeeMenu);

            // COFFEE MENU

            coffeeMenu.Add(new MenuItem
            {
                Name = "Coffee Cake",
                Description = "Crumbly cake topped with cinnamon and walnuts",
                Vegetarian = true,
                Price = 1.59
            });
            coffeeMenu.Add(new MenuItem
            {
                Name = "Bagel",
                Description = "Flavors include sesame, poppyseed, cinnamon raisin, pumpkin",
                Vegetarian = false,
                Price = 0.69
            });
            coffeeMenu.Add(new MenuItem
            {
                Name = "Biscotti",
                Description = "Three almond or hazelnut biscotti cookies",
                Vegetarian = true,
                Price = 0.89
            });

            var waitress = new Waitress(allMenus);
            waitress.PrintMenu();

            // Wait for user
            Console.ReadKey();
        }
    }
}