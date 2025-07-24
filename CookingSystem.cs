using UberProject;

namespace CookingSystem
{
    public class CookingSys
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
                if (foodSatchel[i] == item)
                {
                    foodSatchel[i] = "";
                    break;
                }
            }
        }

        static void DisplayFoodSatchel()
        {
            Console.WriteLine("Food Ingredients:");
            Console.WriteLine("Slot | Item");
            Console.WriteLine("---------------");
            for (int i = 0; i < foodSatchel.Length; i++)
            {
                string item = string.IsNullOrEmpty(foodSatchel[i]) ? "[Empty]" : foodSatchel[i];
                Console.WriteLine($"{i + 1,4} | {item}");
            }
        }

        public static void InventoryManage()
        {
            string temp;
            int input;
            Console.Clear();
            do
            {
                Console.WriteLine("This is your food inventory.\nPress 1 to cook ingredients\nPress 2 to read out your inventory\n\nPress 0 to exit the food inventory"); //Menu text
                temp = Console.ReadLine();
                input = Convert.ToInt32(temp);

                //if (string.IsNullOrWhiteSpace(temp) || !int.TryParse(temp, out input))
                //{
                //    Console.WriteLine("Invalid input, please enter a number.");
                //    Thread.Sleep(1000);
                //    continue;
                //}

                switch (input)
                {
                    default:
                        Program.InvalidInput();
                        break;
                    case 0: //Exit inventory
                        Console.WriteLine("Exiting inventory now");
                        break;
                    case 1: //Scavenges for ingredients and puts it in an empty slot in your inventory
                        Kitchen();
                        break;
                    case 2: //Shows you your inventory
                        Console.WriteLine("Food satchel:");
                        DisplayFoodSatchel();
                        Console.WriteLine("-- End of food inventory. Press enter to go back to menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
                Console.Clear();
            } while (input != 0);
        }

        static void Kitchen()
        {
            string[] ingredientsArr = new string[3];
            ingredientsInput(ref  ingredientsArr);
            Oven(ref ingredientsArr);
            Console.Clear();
        }

        static void ingredientsInput(ref string[] ingredientsArr) //TODO: Make it so you cannot enter in the same slot multiple times
        {
            Console.Clear();
            int input;
            bool validInput;
            Console.WriteLine($"Cookbook:\n{cookbook}");
            DisplayFoodSatchel();
            Console.WriteLine("NOTE: Input 0 for a blank input. Input all 0's twice to exit without making anything (You will have to do another round of ingredient entry for it to take effect. I'm working on it)");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter the slot number of ingredient {i+1}:");
                do
                {
                    validInput = int.TryParse(Console.ReadLine(), out input);
                    if (!validInput)
                    {
                        Program.InvalidInput();
                    }
                } while (!validInput);

                if (input == 0)
                {
                    ingredientsArr[i] = "";
                }
                else if (input > foodSatchel.Length || input < 0)
                {
                    Program.InvalidInput();
                }
                else
                {
                    ingredientsArr[i] = foodSatchel[input-1];
                }
            }
        }
        static void Oven(ref string[] ingredientsArr)
        {
            bool validRecipe = false;
            Recipes[] recipes =
            {
                           new Recipes { recipeName = "Toast", ingredients = new string[] { "Bread", "", "" } },
                           new Recipes { recipeName = "Boiling Water", ingredients = new string[] {"Drinkable-Water", "", "" } },
                           new Recipes { recipeName = "Jam Toast", ingredients = new string[] {"Toast", "Jam", "" } },
                           new Recipes { recipeName = "Russian Steak", ingredients = new string[] {"Meat", "Bread", "Potato" } },
                           new Recipes { recipeName = "Borscht", ingredients = new string[] {"Meat", "Onion", "Potato" } },
                           new Recipes { recipeName = "Varennik", ingredients = new string[] { "Cheese", "Potato", "Eggs" } },
                           new Recipes { recipeName = "Beef Stroganoff", ingredients = new string[] {"Meat", "Sour-Cream", "Onion" } },
                           new Recipes { recipeName = "Solyanka", ingredients = new string[] {"Pickle", "Lemon", "Flour" } },
                           new Recipes { recipeName = "Kutia", ingredients = new string[] {"Rice", "Canned-Fruit", "Flower-Seeds" } },
            };
            do
            {
                for (int i = 0; i < recipes.Length; i++)
                {
                    if (recipes[i].ingredients[0] == ingredientsArr[0] && recipes[i].ingredients[1] == ingredientsArr[1] && recipes[i].ingredients[2] == ingredientsArr[2])
                    {
                        validRecipe = true;
                        RemoveItem(ingredientsArr[0]);
                        RemoveItem(ingredientsArr[1]);
                        RemoveItem(ingredientsArr[2]);
                        GiveItem(recipes[i].recipeName);
                        Console.WriteLine($"You successfully made {recipes[i].recipeName}!");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        if (i >= recipes.Length - 1)
                        {
                            Console.WriteLine("I don't know what to do with this!");
                            Console.ReadLine();
                            ingredientsInput(ref ingredientsArr);
                        }
                        else if (ingredientsArr[0] == "")
                        {
                            validRecipe = true;
                        }
                    }
                }
            } while (!validRecipe);
            
        }

    }
}
