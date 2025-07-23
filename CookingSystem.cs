using UberProject;

namespace CookingSystem
{
    internal class CookingSystem
    {

        public struct Recipes()
        {
            public string recipeName;
            public string[] ingredients = new string[2];
        }

        static string[] foodSatchel = Program.foodSatchel;
        static string cookbook = Program.cookbook;
        static void GiveItem(string item)
        {
            for (int i = 0; i < foodSatchel.Length; i++)
            {
                if (foodSatchel[i] == "")
                {
                    foodSatchel[i] = item;
                    break;
                }
            }
        }
        static void RemoveItem(string item)
        {
            for (int i = 0; i < foodSatchel.Length; i++)
            {
                Console.WriteLine(item);
                Console.ReadLine();
                if (foodSatchel[i] == item)
                {
                    foodSatchel[i] = "";
                    break;
                }
            }
        }

        static void InventoryManage()
        {
            string temp;
            int input;
            Console.Clear();
            do
            {
                Console.WriteLine("Hello. This is your food inventory.\nPress 1 to cook ingredients\nPress 2 to read out your inventory\n\nPress 0 to close the program"); //Menu text
                temp = Console.ReadLine();
                input = Convert.ToInt32(temp);

                if (string.IsNullOrWhiteSpace(temp) || !int.TryParse(temp, out input))
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                    Thread.Sleep(1000);
                    continue;
                }

                switch (input)
                {
                    default:
                        Program.InvalidInput();
                        break;
                    case 0: //Exit inventory
                        Console.WriteLine("Exiting inventory now");
                        break;
                    case 1: //Scavenges for ingredients and puts it in an empty slot in your inventory
                        Cooking();
                        break;
                    case 2: //Shows you your inventory
                        Console.WriteLine("Food satchel:");
                        for (int i = 0; i < foodSatchel.Length; i++)
                        {
                            Console.WriteLine(foodSatchel[i]);
                        }
                        Console.WriteLine("-- End of food inventory. Press enter to go back to menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
                Console.Clear();
            } while (input != 0);
        }

        static void Cooking()
        {
            int input;
            Console.Clear();
            do
            {
                Console.WriteLine("You are now in the cooking menu. What would you like to do?\n1. Start cooking\n2. Read cookbook\n0. Go back to food inventory");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    default:
                        Program.InvalidInput();
                        break;
                    case 1:
                        Kitchen();
                        break;
                    case 2:
                        Console.WriteLine($"{cookbook}\n\n-- Press enter to go back");
                        Console.ReadLine();
                        break;
                    case 0:
                        break;
                }
                Console.Clear();
            } while (input != 0);
        }

        static void Kitchen()
        {
            string ingredientSlot1, ingredientSlot2, ingredientSlot3;
            string[] ingredientsArr = new string[3];
            Console.Clear();
            Console.WriteLine("Food satchel:");
            for (int i = 0; i < foodSatchel.Length; i++)
            {
                Console.WriteLine(foodSatchel[i]);
            }
            Console.WriteLine($"Cookbook:\n{cookbook}");
            Console.ReadLine();
            Console.WriteLine("What is the first ingredient you would like to use?");
            ingredientSlot1 = Console.ReadLine();
            Console.WriteLine("What is the second ingredient you would like to use?");
            ingredientSlot2 = Console.ReadLine();
            Console.WriteLine("What is the third ingredient you would like to use?");
            ingredientSlot3 = Console.ReadLine();
            ingredientsArr[0] = ingredientSlot1;
            ingredientsArr[1] = ingredientSlot2;
            ingredientsArr[2] = ingredientSlot3;
            Oven(ref ingredientsArr);
            Console.Clear();
        }
        static void Oven(ref string[] ingredientsArr)
        {
            Recipes[] recipes =
            {
                           new Recipes { recipeName = "Toast", ingredients = new string[] { "Bread", "", "" } },
                           new Recipes { recipeName = "Boiling Water", ingredients = new string[] {"Drinkable-Water", "", "" } },
                           new Recipes { recipeName = "Salad", ingredients = new string[] {"Lettuce", "Lettuce", "" } },
                           new Recipes { recipeName = "Jam Toast", ingredients = new string[] {"Toast", "Jam", "" } },
                           new Recipes { recipeName = "Russian Steak", ingredients = new string[] {"Meat", "Bread", "Potato" } },
                           new Recipes { recipeName = "Borscht", ingredients = new string[] {"Meat", "Onion", "Potato" } },
                           new Recipes { recipeName = "Varennik", ingredients = new string[] { "Cheese", "Potato", "Eggs" } },
                           new Recipes { recipeName = "Beef Stroganoff", ingredients = new string[] {"Meat", "Sour-Cream", "Onion" } },
                           new Recipes { recipeName = "Solyanka", ingredients = new string[] {"Pickle", "Lemon", "Flour" } },
                           new Recipes { recipeName = "Kutia", ingredients = new string[] {"Rice", "Canned-Fruit", "Flower-Seeds" } },
            };

            for (int i = 0; i < recipes.Length; i++)
            {
                if (recipes[i].ingredients[0].ToLower() == ingredientsArr[0].ToLower() && recipes[i].ingredients[1].ToLower() == ingredientsArr[1].ToLower() && recipes[i].ingredients[2].ToLower() == ingredientsArr[2].ToLower())
                {
                    RemoveItem(ingredientsArr[0]);
                    RemoveItem(ingredientsArr[1]);
                    RemoveItem(ingredientsArr[2]);
                    GiveItem(recipes[i].recipeName);
                }
            }
        }

    }
}
