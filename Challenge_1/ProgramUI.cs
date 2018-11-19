using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class ProgramUI
    {
        CafeRepository _contentCafe = new CafeRepository();
         

        public void Run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Hello, welcome to Komodo Cafe. Please choose an action:" +
                    "\n1. Add item to menu" +
                    "\n2. View menu" +
                    "\n3. Delete item from menu" +
                    "\n4. Exit");
                     

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        AddToMenu();
                        break;
                    case 2:
                        ViewMenu();
                        break;
                    case 3:
                        DeleteFromMenu();
                        break;
                    case 4:
                        isRunning = false;
                        Console.WriteLine("Thank you come again");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("invalid response");
                        Console.ReadLine();
                        break;

                }
            }
        }

        private void AddToMenu()
        {
            Console.WriteLine("what is the number of the item?");
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine("\nwhat is the name of the item?");
            var name = Console.ReadLine();

            Console.WriteLine("\nwhat is the item description?");
            var description = Console.ReadLine();

            Console.WriteLine("\nwhat are the item ingredients");
            var ingredients = Console.ReadLine();

            Console.WriteLine("\nwhat is the price of the item?");
            var price = decimal.Parse(Console.ReadLine());
            Menu newMenu = new Menu()
            {
                MealNumber = number,
                MealName = name,
                MealDescription = description,
                MealIngredients = ingredients,
                MealPrice = price
            };
            _contentCafe.AddMealsToMenu(newMenu);
        }

        private void ViewMenu()
        {
            List<Menu> menuList = _contentCafe.GetMenuList();
            foreach (Menu content in menuList)
            {
                Console.WriteLine(content.MealName);
            }
        }

        private void DeleteFromMenu()
        {
            Console.WriteLine("what is the number of the item?");
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine("\nwhat is the name of the item?");
            var name = Console.ReadLine();

            Menu newMenu = new Menu()
            {
                MealNumber = number,
                MealName = name,
            };
            _contentCafe.RemoveMealsFromMenu(newMenu);
        }  
    }
}
