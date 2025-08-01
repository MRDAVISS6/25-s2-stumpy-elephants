using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Xml.Linq;

namespace FlavoursOfFallout
{
    public struct Player
    {
        public string playerName;
        public int playerHP;
        public string playerWeapon;
        public int playerAttack;
        public Player(string name, int hp, string weapon, int attack)
        {
            this.playerName = name;
            this.playerHP = hp;
            this.playerWeapon = weapon;
            this.playerAttack = attack;
        }
        public override string ToString()
        {
            return $"Name: {playerName} | HP: {playerHP} | Weapon: {playerWeapon} | Attack: {playerAttack}";
        }

        public bool IsAlive => this.playerHP > 0;
                
    }
    
    public struct Weapons()
    {
        public string weaponName;
        public int weaponDamage;
        public string weaponType;
        public string weaponRarity;
        public override string ToString()
        {
            return $"{weaponName} | Damage: {weaponDamage} | Type: {weaponType} | Rarity: {weaponRarity}";
        }
    }
    public struct Ingredients()
    {
        public string ingredientName;
        public override string ToString()
        {
            return $"Name: {ingredientName}";
        }
    }
    public struct Items()
    {
        public string itemName;
        public string itemType;
        public int itemEffectValue;
        public string itemDesc;
        public override string ToString()
        {
            return $"{itemName} | Type: {itemType} | {itemEffectValue} | Description: {itemDesc}";
        }

    }
    public struct Recipes()
    {
        public string recipeName;
        public string ingredient1;
        public string ingredient2;
        public string ingredient3;
        public override string ToString()
        {
            return $"{recipeName} | Ingredient1: {ingredient1} | Ingredient2: {ingredient2} | Ingredient3: {ingredient3}";
        }
    }

    public class Program
    {
        private static Random random = new Random();
        private static int Task;
        public static string charName, cookbook = "";
        public static List<string> inventory = new List<string>(); 
        public static List<string> foodSatchel = new List<string>();

        static void Welcome()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@" ______ _                                          __   ______    _ _             _   
|  ____| |                                        / _| |  ____|  | | |           | |  
| |__  | | __ ___   _____  _   _ _ __ ___    ___ | |_  | |__ __ _| | | ___  _   _| |_ 
|  __| | |/ _` \ \ / / _ \| | | | '__/ __|  / _ \|  _| |  __/ _` | | |/ _ \| | | | __|
| |    | | (_| |\ V / (_) | |_| | |  \__ \ | (_) | |   | | | (_| | | | (_) | |_| | |_ 
|_|    |_|\__,_| \_/ \___/ \__,_|_|  |___/  \___/|_|   |_|  \__,_|_|_|\___/ \__,_|\__|
");
            Console.ResetColor();
            Console.WriteLine("The Menu options are:");
            Console.WriteLine("1  New Game");
            Console.WriteLine("2  Arena");
            Console.WriteLine("3  Collection");
            Console.WriteLine("0  Exit menu system");
            //Console.Beep(659, 200); // E5
            //Console.Beep(659, 200); // E5
            //Thread.Sleep(100);
            //Console.Beep(659, 200); // E5
            //Thread.Sleep(100);
            //Console.Beep(523, 200); // C5
            //Console.Beep(659, 200); // E5
            //Thread.Sleep(100);
            //Console.Beep(784, 200); // G5
            //Thread.Sleep(300);
            //Console.Beep(392, 400); // G4
            Console.WriteLine();
        }

        static void Task1()
        {
            // NEW GAME CREATION --> Lead to Start of Story and Character Creation

            StoryLineSum();
        }

        static void StoryLineSum()
        {
            Console.WriteLine("The story begins with the aftermath of World War III,");
            Thread.Sleep(200);
            Console.WriteLine("complete nuclear devastion plunging every nation into chaos and destruction.");
            Thread.Sleep(200);
            Console.WriteLine("\nCountless lives were lost, families were torn apart,");
            Thread.Sleep(200);
            Console.WriteLine("and the world as we knew it was shattered.");
            Thread.Sleep(200);
            Console.WriteLine("\nThe devastation extended beyond humanity, as nature itself suffered,");
            Thread.Sleep(200);
            Console.WriteLine("with animal species driven to extinction and the air thick with radiation.");
            Thread.Sleep(200);
            Console.WriteLine("\nCommunities vanished, the global population was reduced to a tiny fraction,");
            Thread.Sleep(200);
            Console.WriteLine("and darkness spread to every corner of the earth.");
            Thread.Sleep(200);
            Console.WriteLine("\nIn these desperate times, people prayed for the world to be restored.");
            Thread.Sleep(200);
            Console.WriteLine("\nSome still held onto hope,");
            Thread.Sleep(200);
            Console.WriteLine("believing that one day a savior would emerge to bring balance back to the world.");
            Thread.Sleep(200);
            Console.WriteLine("\nPress any key to know about the main character");
            //Console.Beep(369, 200);
            //Console.Beep(369, 200);
            //Console.Beep(369, 200);
            //Console.Beep(293, 200);
            //Console.Beep(246, 200);
            //Console.Beep(329, 200);
            //Console.Beep(329, 200);
            //Console.Beep(329, 200);
            Console.ReadLine();

            // Lead to Character Creation
            CharacterCreation();
        }

        public static void CharacterCreation()

        {
            Console.Clear();
            Console.WriteLine("Enter the name of the character.");
            charName = Console.ReadLine();
            Player player = new Player(charName, 100, "Steel Pan", 6);

            Console.WriteLine("Sangrur, India - 2040");
            Thread.Sleep(1000);
            Console.WriteLine($"{charName} belonged to a small village and was brought up in a large family. His mother was a housekeeper," +
                $"\nand his father was the Army Chief. His whole family was very patriotic and kind. He wanted to follow in his father’s" +
                $"\nfootsteps and become an Army Officer. He also liked cooking, which was taught to him by his mother, and he wanted to" +
                $"\nuse this side talent in his life. So he wanted to become an Army Chef." +
                $"\nAfter much hard work, he eventually accomplished his goal and started serving in the army.");
            Thread.Sleep(1000);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine($"\nTwo Years Later.........\nRussia Bombed America and World War III started. The whole world was on fire, and people were starving." +
                $"\nIn the attack, {charName} lost his family and his friends fighting on the border. He got badly injured and was sent to the hospital to be treated." +
                $"\nSuddenly, his condition became severe, and he fell into a coma.");
            Thread.Sleep(1000);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine($"\nSix months later, he woke up alone and abandoned, facing a devasted world beyond recognition." +
                $"\nAfter leaving the hospital, he quickly realised how much has changed. Due to the nuclear war," +
                $"\nmany animals had mutated into terrifying creatures. One night, he had a panic attack and felt" +
                $"\nhe had no purpose left in his life; he was fully depressed and had no family or friends." +
                $"\nBut he had no idea that nature had planned something big for him.");
            Thread.Sleep(1000);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine($"After some days, while {charName} was trying to figure out the purpose of his life, he had a dream about his parents." +
                $"\nHe was sitting with them at the dining table, talking about everything that had happened." +
                $"\nHis parents comforted him about the immense tragedy that has befallen mankind, but told him he had the opportunity" +
                $"\nto create something new with his life, by following his passion for cooking and serving people" +
                $"\nhe could be a catalyst towards the rebuilding and revival of humanity.");
            Thread.Sleep(500);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine("\nAfter this dream, he decided to go on a worldwide journey to work towards restoring human civilisation, one meal at a time.");
            Console.WriteLine("\nTo decide where to go first, he threw a dart at a small globe, landing on Russia...");
            Console.WriteLine("Press any key to continue...");
            //Console.Beep(440, 200);
            //Console.Beep(493, 200);
            //Console.Beep(440, 200);
            //Console.Beep(440, 200);
            //Console.Beep(440, 200);
            //Console.Beep(329, 200);
            //Console.Beep(293, 200);
            //Console.Beep(369, 200);
            //Console.Beep(369, 200);
            //Console.Beep(369, 200);
            //Console.Beep(329, 200);
            //Console.Beep(329, 200);
            //Console.Beep(369, 200);
            //Console.Beep(329, 200);

            Console.ReadLine();
            //start of the game

            StartingArea(ref player);

        }
         
        public static void StartingArea(ref Player player)
        { 
            Console.Clear();

            Console.WriteLine("Starting Area - Russia, 2042");
            Thread.Sleep(1500);


            event1(ref player);
        }

    
        static void event1(ref Player player)
        {
            Console.WriteLine("Setting off on his journey, he finally makes it to Russia where he sees immense destruction everywhere." +
                "\nWalking around he desperately tries to find any sign of life, hoping to find survivors he can talk with." +
                "\nSoon he finds himself in a dense forest." +
                "\nAnd suddenly...");
            Thread.Sleep(2000);
            Console.WriteLine("\nYou see a bear running towards you!");
            Console.WriteLine("Prepare yourself!\n\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            //Console.Beep(319, 100);
            //Console.Beep(319, 100);
            //Console.Beep(319, 100);
            //Console.Beep(319, 100);
            //Console.Beep(319, 100);
            //Console.Beep(319, 100);
            //Console.Beep(213, 100);

            Enemy enemy = Enemy.storyModeMonsters[15];

            CombatSystem(ref player, enemy);
            if (!player.IsAlive) return;

            Console.WriteLine("YOU'VE FOUND EPIC LOOT!");
            Thread.Sleep(1000);
            AcquireEpicLoot();

            Console.Clear();
            Console.WriteLine($"After the fight villagers came to see who is in trouble and found {charName}");
            Thread.Sleep(500);
            Console.WriteLine($"The Villagers were very happy to see {charName} and they welcomed him into their village." +
                $"\nThey were very kind and helpful. They told {charName} that they are also trying to survive in this" +
                $"\napocalypse and they are also looking for some food." +
                $"\nSo {charName} decided to help them with his cooking skills and he started cooking for them." +
                $"\nThe Villagers were very happy with his cooking skills and they started calling him Chef {charName}.\n");

            Thread.Sleep(500);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            event2(ref player);
        }

        static void event2(ref Player player)
        {
            Console.Clear();
            Console.WriteLine("After uniting with the villagers he observed their cooking method which was slightly different " +
                "and want to talk with them regarding that. While chatting he got to know some new dishes.\n");
            Thread.Sleep(500);
            Console.WriteLine("Recipe for Russian Steak | Meat -> Bread -> Potato.");
            Thread.Sleep(500);
            cookbook = cookbook + "[Russian Steak | Meat -> Bread -> Potato] ";
            foodSatchel.Add("Bread");
            foodSatchel.Add("Meat");
            foodSatchel.Add("Potato");
            foodSatchel.Add("Butter");
            Console.WriteLine("Press any button to cook new dish");
            Console.ReadLine();
            CookingSystem.SatchelManage();

            Console.WriteLine("Press any button to continue...");
            Console.ReadLine();
            //end of event and he continues his journey

            event3(ref player);
        }

        static void event3(ref Player player)
        {
            Console.Clear();
            Console.WriteLine($"Now Continuing in Russia {charName} reached Moscow." +
                $"\nHe saw that the city is pretty much destroyed and the vibes are pretty depressed in the city." +
                $"\nRoaming around he met a bunch of people taking part in group mental therapy and decided to join them." +
                $"\nDuring the conversations he told them his passion of cooking and about his journey." +
                $"\nSo other persons shared their favorite recipes and ingredients with him.");
            Console.WriteLine();
            Console.WriteLine("The recipies are following:");
            Console.WriteLine("1. Borcht | Meat -> Onion -> Potato");
            Console.WriteLine("2. Solyanka | Pickle -> Lemon -> Flour");
            cookbook = cookbook + "[Borcht | Meat -> Onion -> Potato] ";
            cookbook = cookbook + "[Solyanka | Pickle -> Lemon -> Flour] ";
            foodSatchel.Add("Meat");
            foodSatchel.Add("Potato");
            foodSatchel.Add("Onion");
            foodSatchel.Add("Pickle");
            foodSatchel.Add("Lemon");
            foodSatchel.Add("Flour");
            Console.WriteLine("Press any button to cook new dish");
            Console.ReadLine();
            CookingSystem.SatchelManage();


            Console.WriteLine("Press any button to continue...");
            Console.ReadLine();

            event4(ref player);
        }

        static void event4(ref Player player)
        {
            string input, temp;
            Console.Clear();
            Console.WriteLine("Back outside roaming the wasteland you come across what used to be an old car park. " +
                "\nTattered green tents lay across it, and military jeeps create barricades." +
                "\nYou can tell it had long since been abandoned." +
                "\nAll of a sudden a crow comes eye to eye with you, twitchingly eyeing you up.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            //Console.Beep(319, 100);
            //Console.Beep(319, 100);
            //Console.Beep(319, 100);
            //Console.Beep(319, 100);
            //Console.Beep(319, 100);
            //Console.Beep(319, 100);
            //Console.Beep(213, 100);
            Enemy enemy = Enemy.storyModeMonsters[14];
            CombatSystem(ref player, enemy); //Crow fight
            if (!player.IsAlive) return;
            Console.Clear();
            Console.WriteLine("You notice that the crow has given you bite marks. It seems that over time it has evolved teeth to chew through the armour plating that the military soldiers have." +
                "\nIt seems that you have caused quite the commotion during your fight, and now all of the crows want to see what's going on");
            Console.WriteLine("You couldn't outrun them if you tried, unless you managed to find a distraction." +
                "\nThe meat you're carrying will do just fine. Or you can engage with them, and see what the soldiers left behind");
            Console.WriteLine("r|   Sacrifice all meat and run away     f|    Fight 5 crows back to back");
            input = Console.ReadLine();
            switch (input)
            {
                case "f":
                    string baseName = enemy.enemyName;
                    for (int i = 0; i < 5; i++)
                    {
                        enemy.enemyName = baseName + $" #{i+1}"; // give each crow a number
                        CombatSystem(ref player, enemy); //Fight 5 crows
                        if (!player.IsAlive) return;
                    }
                    
                    Console.WriteLine("YOU'VE FOUND EPIC LOOT!");
                    Thread.Sleep(1000);
                    AcquireEpicLoot();
                    break;
                case "r":
                    for (int i = 0; i < foodSatchel.Count; i++)
                    {
                        if (foodSatchel[i] == "Meat" ||  foodSatchel[i] == "Fish")
                        {
                            temp = foodSatchel[i];
                            foodSatchel.Remove(temp);
                        }
                    }
                    Console.WriteLine("You run away, losing all your meat");
                    break;
            }
            Console.ReadLine();

            event5(ref player);
        }

        static void event5(ref Player player)
        {
            Console.Clear();
            Console.WriteLine($"As night approaches, {charName} finds himself walking through a run-down mall, heading towards the food court to keep warm throughout the night." +
                $"\nExpecting trouble, {charName} is surprised to see a small community surviving deep inside the mall.");
            Console.WriteLine($"Coming down to meet the survivors, they instantly welcome {charName} into their community." +
                $"\n{charName} explained their dream of helping people, and the survivors told them that they believed that" +
                $"\none day a messiah would come to save us all, and that {charName} should eat a meal with them");
            Console.WriteLine($"They taught {charName} the recipe of Kutia | Rice -> Canned Fruits -> Flower Seeds");
            Console.ReadLine();
            cookbook = cookbook + "[Kutia | Rice -> Canned Fruits -> Flower Seeds] ";
            foodSatchel.Add("Rice");
            foodSatchel.Add("Canned Fruits");
            foodSatchel.Add("Flower Seeds");
            Console.WriteLine("Kutia was added to your cookbook");
            Console.WriteLine("Press any button to cook new dish");
            Console.ReadLine();
            CookingSystem.SatchelManage();
            Console.WriteLine("Press any button to continue...");
            Console.ReadLine();

            endEvent(ref player);
        }

        static void endEvent(ref Player player)
        {
            
            Console.WriteLine($"In the morning {charName} hears reports that there is a Military base near Moscow where a chef teacher is needed and they can use his help.");
            Console.WriteLine($"\nSo he went there and saw bunch of young soldiers eating any scraps they can get their hands on, " +
                $"\nsome even psychoticly choosing to eat human flesh to survive." +
                $"\nSo {charName} approached them but suddenly siren starts ringing and news is a massive Mutant Scorpion has broken through into the outpost!");
            Console.WriteLine($"{charName} decided to help the other soldiers");
            Thread.Sleep(2000);
            Console.WriteLine($"Prepare to FIGHT!!!");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            //Console.Beep(319, 100);
            //Console.Beep(319, 100);
            //Console.Beep(319, 100);
            //Console.Beep(319, 100);
            //Console.Beep(319, 100);
            //Console.Beep(319, 100);
            //Console.Beep(213, 100);
            Thread.Sleep(500);
            Enemy enemy = Enemy.storyModeMonsters[3];

            CombatSystem(ref player, enemy);
            if (!player.IsAlive) return;

            //fighting scene will come here
            Console.Clear();
            Console.WriteLine($"After the fight {charName} gained the trust of the soldiers and now started to teach the soldiers some new cooking methods.");
            Console.WriteLine($"In this whole journey {charName} learned lots of new dishes which are:");
            Console.WriteLine("Beef stroganoff - Meat, Sour Cream, Onions");
            Console.WriteLine("Varenniki - Cheese, Potato, Eggs");
            Console.ReadLine();

            Console.WriteLine("Now these recipies are added in your inventory");
            cookbook = cookbook + "[Varenniki | Cheese -> Potato -> Eggs] ";
            cookbook = cookbook + "[Beef stroganoff | Meat -> Sour Cream -> Onions] ";
            foodSatchel.Add("Meat");
            foodSatchel.Add("Potato");
            foodSatchel.Add("Cheese");
            foodSatchel.Add("Eggs");
            foodSatchel.Add("Sour Cream");
            foodSatchel.Add("Onions");

            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("Press any button to cook new dish");
            Console.ReadLine();
            CookingSystem.SatchelManage();
            Console.WriteLine("Press any button to continue...");
            Console.ReadLine();

            Console.WriteLine("Thanks for playing the game. Hope you enjoyed it.");
            Console.WriteLine("To exit press Enter.");
            Console.ReadLine();
            Console.WriteLine("The Chef will return with his journey in the next part." +
                "\nComing SOON!!....\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" _____ _                      _____          _ \r\n|_   _| |                    |  ___|        | |\r\n  | | | |__   ___            | |__ _ __   __| |\r\n  | | | '_ \\ / _ \\           |  __| '_ \\ / _` |\r\n  | | | | | |  __/           | |__| | | | (_| |\r\n  \\_/ |_| |_|\\___|           \\____/_| |_|\\__,_|\r\n                                               \r\n                                               ");
            Console.ReadLine();
        }


        public static void CombatSystem(ref Player player, Enemy enemy)
        {
            int choice;
            string temp;

            while (player.playerHP > 0 && enemy.enemyHP > 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Player: {player.playerName} | HP: {player.playerHP} | Weapon: {player.playerWeapon} | Attack: {player.playerAttack}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("VS".PadLeft(30));
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Enemy: {enemy.enemyName} | HP: {enemy.enemyHP} | Attack: {enemy.enemyAttack}");
                Console.WriteLine($"Description: {enemy.enemyDesc}");

                Console.ResetColor();

                Console.WriteLine("What do you want to do?");

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Open Inventory");
                
                temp = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(temp) || !int.TryParse(temp, out choice))
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                    Thread.Sleep(1000);
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        // Attack
                        int pAttack = player.playerAttack + random.Next(-2, 3);
                        enemy.enemyHP = enemy.enemyHP - pAttack;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{player.playerName} attacks {enemy.enemyName} for {pAttack} damage!");
                        //Console.Beep(400, 100);
                        Console.ResetColor();
                        Thread.Sleep(700);

                        if (enemy.enemyHP <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{enemy.enemyName} is defeated!");
                            //Console.Beep(800, 300);
                            Console.ResetColor();
                            break;
                        }


                        int eAttack = enemy.enemyAttack + random.Next(-2,3);
                        player.playerHP = player.playerHP - eAttack;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"{enemy.enemyName} attacks {player.playerName} for {eAttack} damage!");
                        //Console.Beep(200, 150);
                        Console.ResetColor();
                        break;

                    case 2:
                        // Open Inventory
                        DisplayInventory(ref player, ref enemy);
                        continue;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        continue;
                }

                if (player.playerHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{player.playerName} has been defeated!");
                    Console.ResetColor();
                    break;
                }
            }
            if (!player.IsAlive) Console.WriteLine("GAME OVER! Press Enter to exit...");
            else Console.WriteLine("Combat ended. Press Enter to continue...");
            Console.ReadLine();

        }


        static void DisplayInventory(ref Player player, ref Enemy enemy)
        {
            Console.Clear();
            Console.WriteLine("" +
                " _____                     _                   \r\n" +
                "|_   _|                   | |                  \r\n" +
                "  | | _ ____   _____ _ __ | |_ ___  _ __ _   _ \r\n" +
                "  | || '_ \\ \\ / / _ \\ '_ \\| __/ _ \\| '__| | | |\r\n" +
                " _| || | | \\ V /  __/ | | | || (_) | |  | |_| |\r\n" +
                " \\___/_| |_|\\_/ \\___|_| |_|\\__\\___/|_|   \\__, |\r\n" +
                "                                          __/ |\r\n" +
                "                                         |___/ ");
            Console.WriteLine(" Slot │ Item ");
            if (inventory.Count == 0)
            {
                Console.WriteLine("──────┴────────");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your inventory is empty!");
                Console.ResetColor();
                Console.WriteLine("Press enter to go back");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("──────┼────────");
                for (int i = 0; i < inventory.Count; i++)
                {
                    string item = inventory[i];
                    Console.WriteLine($"{i + 1,5} │ {item}");
                }
            }
                
            Console.WriteLine();

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Use an item");
            Console.WriteLine("2. Equip a weapon");
            Console.WriteLine("3. Drop item");
            Console.WriteLine("4. Return to combat");

            int choice;
            string temp = Console.ReadLine();
            choice = Convert.ToInt32(temp);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the slot number of the item you want to use:");
                    int itemSlot;
                    temp = Console.ReadLine();
                    itemSlot = Convert.ToInt32(temp) - 1;
                    if (itemSlot >= 0 && itemSlot < inventory.Count && !string.IsNullOrEmpty(inventory[itemSlot]))
                    {
                        string[] itemDetails = inventory[itemSlot].Split(" - ");    // Didn't change into a list as the .Split didn't like it
                        if (itemDetails.Length >= 3 && itemDetails[1] == "Healing")
                        {
                            int healAmount = Convert.ToInt32(itemDetails[2]);
                            player.playerHP = player.playerHP + healAmount;
                            Console.WriteLine($"You used {itemDetails[0]} and healed for {healAmount} HP!");
                            inventory.RemoveAt(itemSlot);
                            Console.ReadLine();
                        }
                        else if (itemDetails.Length >= 3 && itemDetails[1] == "Explosive")
                        {
                            int damageAmount = Convert.ToInt32(itemDetails[2]);
                            enemy.enemyHP = enemy.enemyHP - damageAmount;
                            Console.WriteLine("***HUGE EXPLOSIONS***");
                            Console.WriteLine($"You used {itemDetails[0]} against {enemy.enemyName} dealing {damageAmount} damage!");
                            inventory.RemoveAt(itemSlot);
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid slot number or empty slot.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the slot number of the weapon you want to equip:");
                    int weaponSlot;
                    temp = Console.ReadLine();
                    weaponSlot = Convert.ToInt32(temp) - 1;
                    if (weaponSlot >= 0 && weaponSlot < inventory.Count && !string.IsNullOrEmpty(inventory[weaponSlot]))
                    {
                        string[] weaponDetails = inventory[weaponSlot].Split(" - ");
                        if (weaponDetails.Length >= 4)
                        {
                            player.playerWeapon = weaponDetails[0];
                            player.playerAttack = Convert.ToInt32(weaponDetails[1]);
                            Console.WriteLine($"You equipped {player.playerWeapon} with {player.playerAttack} attack power!");
                            inventory.RemoveAt(weaponSlot);
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Invalid weapon details.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid slot number or empty slot.");
                    }
                    break;

                    case 3:
                    Console.WriteLine("Enter the slot number of the item you want to drop:");
                    int dropSlot;
                    temp = Console.ReadLine();
                    dropSlot = Convert.ToInt32(temp) - 1;
                    if (dropSlot >= 0 && dropSlot < inventory.Count && !string.IsNullOrEmpty(inventory[dropSlot]))
                    {
                        inventory.RemoveAt(dropSlot);
                    }
                    else
                    {
                        Console.WriteLine("Invalid slot number or empty slot.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Returning to combat...");
                    Thread.Sleep(1000);
                    return;
            }


        }

        public static void AcquireEpicLoot()
        {
            // This will be an Array of Loot that you can randomly acquire through different events and fights.

            List<Weapons> weapons =
            [
                new Weapons { weaponName = "Rusty Pipe Rifle", weaponDamage = 7, weaponType = "Ranged", weaponRarity = "Common" },
                new Weapons { weaponName = "Spiked Baseball Bat", weaponDamage = 8, weaponType = "Melee", weaponRarity = "Common" },
                new Weapons { weaponName = "Radiation Axe", weaponDamage = 9, weaponType = "Melee", weaponRarity = "Common" },
                new Weapons { weaponName = "Jury-Rigged Laser Pistol", weaponDamage = 10, weaponType = "Energy", weaponRarity = "Common" },
                new Weapons { weaponName = "Toxic Syringe Gun", weaponDamage = 11, weaponType = "Ranged", weaponRarity = "Common" },
                new Weapons { weaponName = "Electrified Machete", weaponDamage = 12, weaponType = "Melee", weaponRarity = "Common" },
            
                new Weapons { weaponName = "Hunting Rifle", weaponDamage = 13, weaponType = "Ranged", weaponRarity = "Rare" },
                new Weapons { weaponName = "Sawblade Launcher", weaponDamage = 14, weaponType = "Ranged", weaponRarity = "Rare" },
                new Weapons { weaponName = "Combat Shotgun", weaponDamage = 15, weaponType = "Ranged", weaponRarity = "Rare" },
                new Weapons { weaponName = "Flamer", weaponDamage = 16, weaponType = "Heavy", weaponRarity = "Rare" },
                new Weapons { weaponName = "Super Sledge", weaponDamage = 17, weaponType = "Melee", weaponRarity = "Rare" },
                new Weapons { weaponName = "Laser Musket", weaponDamage = 18, weaponType = "Energy", weaponRarity = "Rare" },
            
                new Weapons { weaponName = "Experimental Gauss Rifle", weaponDamage = 19, weaponType = "Energy", weaponRarity = "Epic" },
                new Weapons { weaponName = "Tesla Cannon", weaponDamage = 20, weaponType = "Energy", weaponRarity = "Epic" },
                new Weapons { weaponName = "Incendiary Chainsaw", weaponDamage = 21, weaponType = "Melee", weaponRarity = "Epic" },
                new Weapons { weaponName = "Cryolator", weaponDamage = 22, weaponType = "Energy", weaponRarity = "Epic" },
                new Weapons { weaponName = "Railway Rifle", weaponDamage = 23, weaponType = "Ranged", weaponRarity = "Epic" },
                new Weapons { weaponName = "Auto-Axe", weaponDamage = 24, weaponType = "Melee", weaponRarity = "Epic" },
            
                new Weapons { weaponName = "Plague Injector", weaponDamage = 25, weaponType = "Ranged", weaponRarity = "*Legendary*" },
                new Weapons { weaponName = "Hellfire Minigun", weaponDamage = 26, weaponType = "Heavy", weaponRarity = "*Legendary*" },
                new Weapons { weaponName = "Quantum Disruptor", weaponDamage = 27, weaponType = "Energy", weaponRarity = "*Legendary*" },
                new Weapons { weaponName = "Oblivion Hammer", weaponDamage = 28, weaponType = "Melee", weaponRarity = "*Legendary*" },
                new Weapons { weaponName = "Apocalypse Blade", weaponDamage = 29, weaponType = "Melee", weaponRarity = "*Legendary*" },
                new Weapons { weaponName = "Mini Nuke Launcher", weaponDamage = 30, weaponType = "Explosive", weaponRarity = "*Legendary*" },
            ];


            List<Ingredients> ingredients =
            [
                new Ingredients { ingredientName = "Bread" },
                new Ingredients { ingredientName = "Lettuce" },
                new Ingredients { ingredientName = "Tomato" },
                new Ingredients { ingredientName = "Cheese" },
                new Ingredients { ingredientName = "Meat" },
                new Ingredients { ingredientName = "Egg" },
                new Ingredients { ingredientName = "Potato" },
                new Ingredients { ingredientName = "Carrot" },
                new Ingredients { ingredientName = "Onion" },
                new Ingredients { ingredientName = "Garlic" },
                new Ingredients { ingredientName = "Salt" },
                new Ingredients { ingredientName = "Pepper" },
                new Ingredients { ingredientName = "Drinkable Water" },
                new Ingredients { ingredientName = "Jam" },
                new Ingredients { ingredientName = "Milk" },
                new Ingredients { ingredientName = "Butter" },
                new Ingredients { ingredientName = "Mushroom" },
                new Ingredients { ingredientName = "Fish" },
                new Ingredients { ingredientName = "Apple" },
                new Ingredients { ingredientName = "Mutfruit" }
            ];

            List<Items> items =
            [
                new Items { itemName = "Stimpak", itemType = "Healing", itemEffectValue = 20, itemDesc = "A medical kit that heals wounds and restores health." },
                new Items { itemName = "RadAway", itemType = "Healing", itemEffectValue = 15, itemDesc = "A serum that removes radiation from the body." },
                new Items { itemName = "Antiseptic Bandage", itemType = "Healing", itemEffectValue = 12, itemDesc = "A bandage soaked in antiseptic, heals minor wounds." },
                new Items { itemName = "Molotov Cocktail", itemType = "Explosive", itemEffectValue = 18, itemDesc = "A bottle filled with flammable liquid, deals fire damage." },
                new Items { itemName = "Fragmentation Grenade", itemType = "Explosive", itemEffectValue = 20, itemDesc = "A standard grenade that explodes into deadly shrapnel." },
                new Items { itemName = "Plasma Mine", itemType = "Explosive", itemEffectValue = 24, itemDesc = "A mine that detonates with a burst of plasma energy." },
                new Items { itemName = "Dynamite Bundle", itemType = "Explosive", itemEffectValue = 30, itemDesc = "A bundle of dynamite sticks, causes a large explosion." },
                new Items { itemName = "Cryo Grenade", itemType = "Explosive", itemEffectValue = 15, itemDesc = "A grenade that explodes with a freezing blast, slowing enemies." },
                new Items { itemName = "Purified Water", itemType = "Healing", itemEffectValue = 10, itemDesc = "Clean water that hydrates and restores minor health." },

            ];

            int weaponLootRarity = random.Next(1,101);
            int weaponLoot;
            int itemLoot1 = random.Next(items.Count);
            int itemLoot2 = random.Next(items.Count);
            int ingredientLoot = random.Next(ingredients.Count);

            if (weaponLootRarity <= 40)
            {
                weaponLoot = random.Next(0, 6); // Common Weapons

            }
            else if (weaponLootRarity > 40 && weaponLootRarity < 70)
            {
                weaponLoot = random.Next(6, 12); // Rare Weapons
            }
            else if (weaponLootRarity >= 70 && weaponLootRarity < 90)
            {
                weaponLoot = random.Next(12, 18); // Epic Weapons
            }
            else
            {
                weaponLoot = random.Next(18, 24); // Legendary Weapons
            }

            Weapons acquiredEpicWeapon = weapons[weaponLoot];
            Items acquiredItem1 = items[itemLoot1];
            Items acquiredItem2 = items[itemLoot2];
            Ingredients acquiredIngredient = ingredients[ingredientLoot];

            inventory.Add($"{acquiredEpicWeapon.weaponName} - {acquiredEpicWeapon.weaponDamage} - {acquiredEpicWeapon.weaponType} - {acquiredEpicWeapon.weaponRarity}");

            Console.WriteLine("You have received ");

            if (weapons[weaponLoot].weaponRarity == "Common")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (weapons[weaponLoot].weaponRarity == "Rare")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (weapons[weaponLoot].weaponRarity == "Epic")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (weapons[weaponLoot].weaponRarity == "*Legendary*")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            Console.Write($"{acquiredEpicWeapon}");

            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine($"You have received {acquiredItem1.itemName}");
            Thread.Sleep(1000);

            inventory.Add($"{acquiredItem1.itemName} - {acquiredItem1.itemType} - {acquiredItem1.itemEffectValue}");

            Console.WriteLine($"You have received {acquiredItem2.itemName}");
            Thread.Sleep(1000);
            Console.WriteLine();

            inventory.Add($"{acquiredItem2.itemName} - {acquiredItem2.itemType} - {acquiredItem2.itemEffectValue}");

            Console.WriteLine("Press any button to continue...");
            Console.ReadLine();

        }


        
        public static void Task3()
        {
            // Collection of Things
            string userInput;

            do
            {

                Console.WriteLine("Welcome to the collection of things in our game");
                Console.WriteLine("The Menu options are:");
                Console.WriteLine("1  Monsters");
                Console.WriteLine("2  Weapons");
                Console.WriteLine("3  Items");
                Console.WriteLine("4  Ingredients");
                Console.WriteLine("5  Recipes");
                Console.WriteLine();
                Console.WriteLine("0  Exit menu system");

                Console.WriteLine();
                Console.WriteLine("Please choose an option");
                userInput = Console.ReadLine();
                

                Console.Clear();

                switch (userInput)

                {
                    case "1":
                        // Display all enemies in a readable format
                        List<Enemy> monsters =
                        [
                            new Enemy("Mirelurk", 30, 5, "A mutated crab-like creature with a hard shell and a vicious bite."),
                            new Enemy("Super Mutant", 40, 8, "A hulking brute with enhanced strength and resilience, often armed with heavy weapons."),
                            new Enemy("Deathclaw", 50, 10, "A terrifying predator with razor-sharp claws and incredible speed."),
                            new Enemy("Radscorpion", 35, 7, "A giant scorpion with a venomous sting and armored exoskeleton."),
                            new Enemy("Radroach", 20, 4, "Giant irradiated cockroach with acidic saliva and armored carapace"),
                            new Enemy("Mutant Hound", 35, 7, "Once a domestic dog, now a grotesque, hairless predator with enhanced senses and aggression."),
                            new Enemy("Ash Crawler", 25, 5, "A pale, skeletal creature that burrows through radioactive ash, ambushing prey from below."),
                            new Enemy("Ghoul Reaper", 30, 6, "A sentient, decaying humanoid that hunts the living for flesh, often in packs."),
                            new Enemy("Wasteland Abomination", 50, 10, "A massive fusion of flesh and machinery, created from failed experiments and scavenged tech."),
                            new Enemy("Irradiated Behemoth", 60, 12, "Towering brute pulsing with nuclear energy, leaving scorched earth in its wake."),
                            new Enemy("Scorched Stalker", 28, 6, "Burn-scarred humanoid with smoldering skin, capable of setting traps and ambushes."),
                            new Enemy("Toxic Spitter", 22, 5, "A bloated mutant that expels corrosive bile from a distended jaw."),
                            new Enemy("Bone Dragger", 26, 5, "Lurks in the shadows, dragging scavenged bones across the ground to lure victims."),
                            new Enemy("Nuke Leech", 18, 3, "A glowing, slug-like parasite that feeds on radiation and attaches to living hosts.")
                        ];
                        Console.WriteLine("Monsters in the game:\n");
                        foreach (var enemy in monsters)
                        {
                            Console.WriteLine(enemy);
                        }
                        Console.WriteLine("\n-- Press any key to return to the collection menu --");
                        Console.ReadLine();
                        break;

                    case "2":
                        // Display all weapons in a readable format
                        List<Weapons> tier1weapons =
                        [
                            new Weapons { weaponName = "Rusty Pipe Rifle", weaponDamage = 12, weaponType = "Ranged" },
                            new Weapons { weaponName = "Spiked Baseball Bat", weaponDamage = 10, weaponType = "Melee" },
                            new Weapons { weaponName = "Radiation Axe", weaponDamage = 14, weaponType = "Melee" },
                            new Weapons { weaponName = "Jury-Rigged Laser Pistol", weaponDamage = 16, weaponType = "Energy" },
                            new Weapons { weaponName = "Toxic Syringe Gun", weaponDamage = 13, weaponType = "Ranged" },
                            new Weapons { weaponName = "Electrified Machete", weaponDamage = 17, weaponType = "Melee" }
                        ];
                        List<Weapons> tier2weapons =
                        [
                            new Weapons { weaponName = "Hunting Rifle", weaponDamage = 25, weaponType = "Ranged" },
                            new Weapons { weaponName = "Sawblade Launcher", weaponDamage = 30, weaponType = "Ranged" },
                            new Weapons { weaponName = "Combat Shotgun", weaponDamage = 30, weaponType = "Ranged" },
                            new Weapons { weaponName = "Flamer", weaponDamage = 35, weaponType = "Heavy" },
                            new Weapons { weaponName = "Super Sledge", weaponDamage = 28, weaponType = "Melee" },
                            new Weapons { weaponName = "Laser Musket", weaponDamage = 32, weaponType = "Energy" },
                        ];
                        List<Weapons> tier3weapons =
                        [
                            new Weapons { weaponName = "Experimental Gauss Rifle", weaponDamage = 55, weaponType = "Energy" },
                            new Weapons { weaponName = "Tesla Cannon", weaponDamage = 65, weaponType = "Energy" },
                            new Weapons { weaponName = "Incendiary Chainsaw", weaponDamage = 50, weaponType = "Melee" },
                            new Weapons { weaponName = "Cryolator", weaponDamage = 60, weaponType = "Energy" },
                            new Weapons { weaponName = "Railway Rifle", weaponDamage = 58, weaponType = "Ranged" },
                            new Weapons { weaponName = "Auto-Axe", weaponDamage = 52, weaponType = "Melee" }
                        ];
                        List<Weapons> tier4weapons =
                        [
                            new Weapons { weaponName = "Mini Nuke Launcher", weaponDamage = 100, weaponType = "Explosive" },
                            new Weapons { weaponName = "Plague Injector", weaponDamage = 80, weaponType = "Ranged" },
                            new Weapons { weaponName = "Hellfire Minigun", weaponDamage = 90, weaponType = "Heavy" },
                            new Weapons { weaponName = "Quantum Disruptor", weaponDamage = 110, weaponType = "Energy" },
                            new Weapons { weaponName = "Oblivion Hammer", weaponDamage = 95, weaponType = "Melee" },
                            new Weapons { weaponName = "Apocalypse Blade", weaponDamage = 105, weaponType = "Melee" },
                        ];

                        Console.WriteLine("Weapons in the game:\n");

                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Tier 1 Weapons:");
                        foreach (var weapon in tier1weapons)
                        {
                            Console.WriteLine($"Name: {weapon.weaponName}, Damage: {weapon.weaponDamage}, Type: {weapon.weaponType}");
                        }
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tier 2 Weapons:");
                        foreach (var weapon in tier2weapons)
                        {
                            Console.WriteLine($"Name: {weapon.weaponName}, Damage: {weapon.weaponDamage}, Type: {weapon.weaponType}");
                        }
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Tier 3 Weapons:");
                        foreach (var weapon in tier3weapons)
                        {
                            Console.WriteLine($"Name: {weapon.weaponName}, Damage: {weapon.weaponDamage}, Type: {weapon.weaponType}");
                        }
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Tier 4 Weapons:");
                        foreach (var weapon in tier4weapons)
                        {
                            Console.WriteLine($"Name: {weapon.weaponName}, Damage: {weapon.weaponDamage}, Type: {weapon.weaponType}");
                        }

                        Console.ResetColor();

                        Console.WriteLine("\n-- Press any key to return to the collection menu --");
                        Console.ReadLine();
                        break;

                    case "3":
                        // Display all items in a readable format
                        List<Items> items =
                        [
                            new Items { itemName = "Stimpak", itemType = "Healing", itemEffectValue = 20, itemDesc = "A medical kit that heals wounds and restores health." },
                            new Items { itemName = "RadAway", itemType = "Healing", itemEffectValue = 15, itemDesc = "A serum that removes radiation from the body." },
                            new Items { itemName = "Antiseptic Bandage", itemType = "Healing", itemEffectValue = 12, itemDesc = "A bandage soaked in antiseptic, heals minor wounds." },
                            new Items { itemName = "Molotov Cocktail", itemType = "Explosive", itemEffectValue = 18, itemDesc = "A bottle filled with flammable liquid, deals fire damage." },
                            new Items { itemName = "Fragmentation Grenade", itemType = "Explosive", itemEffectValue = 20, itemDesc = "A standard grenade that explodes into deadly shrapnel." },
                            new Items { itemName = "Plasma Mine", itemType = "Explosive", itemEffectValue = 24, itemDesc = "A mine that detonates with a burst of plasma energy." },
                            new Items { itemName = "Dynamite Bundle", itemType = "Explosive", itemEffectValue = 30, itemDesc = "A bundle of dynamite sticks, causes a large explosion." },
                            new Items { itemName = "Cryo Grenade", itemType = "Explosive", itemEffectValue = 15, itemDesc = "A grenade that explodes with a freezing blast, slowing enemies." },
                            new Items { itemName = "Purified Water", itemType = "Healing", itemEffectValue = 10, itemDesc = "Clean water that hydrates and restores minor health." },
                        ];

                        Console.WriteLine("Items in the game:\n");
                        foreach (var item in items)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n-- Press any key to return to the collection menu --");
                        Console.ReadLine();
                        break;

                    case "4":
                        // Display all ingredients in a readable format
                        List<Ingredients> ingredients =
                        [
                            new Ingredients { ingredientName = "Bread" },
                            new Ingredients { ingredientName = "Lettuce" },
                            new Ingredients { ingredientName = "Tomato" },
                            new Ingredients { ingredientName = "Cheese" },
                            new Ingredients { ingredientName = "Meat" },
                            new Ingredients { ingredientName = "Egg" },
                            new Ingredients { ingredientName = "Potato" },
                            new Ingredients { ingredientName = "Carrot" },
                            new Ingredients { ingredientName = "Onion" },
                            new Ingredients { ingredientName = "Garlic" },
                            new Ingredients { ingredientName = "Salt" },
                            new Ingredients { ingredientName = "Pepper" },
                            new Ingredients { ingredientName = "Drinkable Water" },
                            new Ingredients { ingredientName = "Jam" },
                            new Ingredients { ingredientName = "Milk" },
                            new Ingredients { ingredientName = "Butter" },
                            new Ingredients { ingredientName = "Mushroom" },
                            new Ingredients { ingredientName = "Fish" },
                            new Ingredients { ingredientName = "Apple" },
                            new Ingredients { ingredientName = "Mutfruit" }
                        ];
                        Console.WriteLine("Ingredients in the game:\n");
                        foreach (var ingredient in ingredients)
                        {
                            Console.WriteLine(ingredient);
                        }
                        Console.WriteLine("\n-- Press any key to return to the collection menu --");
                        Console.ReadLine();
                        break;

                    case "5":
                        // Display all recipes in a readable format
                        List<Recipes> recipes =
                        [
                            new Recipes { recipeName = "Russian Steak", ingredient1 = "Meat", ingredient2 = "Potato", ingredient3 = "Butter" },
                            new Recipes { recipeName = "Nuka-Cola Cake", ingredient1 = "Flour", ingredient2 = "Sugar", ingredient3 = "Nuka-Cola" },
                            new Recipes { recipeName = "Mutfruit Salad", ingredient1 = "Mutfruit", ingredient2 = "Lettuce", ingredient3 = "Tomato" },
                            new Recipes { recipeName = "Radroach Stew", ingredient1 = "Radroach Meat", ingredient2 = "Potato", ingredient3 = "Carrot" },
                            new Recipes { recipeName = "Wasteland Omelette", ingredient1 = "Egg", ingredient2 = "Cheese", ingredient3 = "Onion" },
                            new Recipes { recipeName = "Mirelurk Pie", ingredient1 = "Mirelurk Meat", ingredient2 = "Potato", ingredient3 = "Salt" },
                            new Recipes { recipeName = "Mutant Hound Jerky", ingredient1 = "Mutant Hound Meat", ingredient2 = "Salt", ingredient3 = "Pepper" },
                            new Recipes { recipeName = "Ghoul Goulash", ingredient1 = "Ghoul Meat", ingredient2 = "Carrot", ingredient3 = "Onion" },
                            new Recipes { recipeName = "Irradiated Apple Jam", ingredient1 = "Apple", ingredient2 = "Sugar", ingredient3 = "Jam" },
                            new Recipes { recipeName = "Cheesy Potato Soup", ingredient1 = "Potato", ingredient2 = "Cheese", ingredient3 = "Drinkable Water" },
                            new Recipes { recipeName = "Fried Fish Fillet", ingredient1 = "Fish", ingredient2 = "Butter", ingredient3 = "Salt" },
                            new Recipes { recipeName = "Mushroom Stew", ingredient1 = "Mushroom", ingredient2 = "Onion", ingredient3 = "Drinkable Water" },
                            new Recipes { recipeName = "Egg & Mutfruit Breakfast", ingredient1 = "Egg", ingredient2 = "Mutfruit", ingredient3 = "Milk" },
                            new Recipes { recipeName = "Carrot & Potato Mash", ingredient1 = "Carrot", ingredient2 = "Potato", ingredient3 = "Butter" },
                            new Recipes { recipeName = "Spicy Meat Skewer", ingredient1 = "Meat", ingredient2 = "Pepper", ingredient3 = "Onion" },
                            new Recipes { recipeName = "Garlic Bread", ingredient1 = "Bread", ingredient2 = "Butter", ingredient3 = "Garlic" },
                            new Recipes { recipeName = "Apple Pie", ingredient1 = "Apple", ingredient2 = "Flour", ingredient3 = "Butter" },
                            new Recipes { recipeName = "Mutfruit Jam Toast", ingredient1 = "Toast", ingredient2 = "Mutfruit", ingredient3 = "Jam" },
                            new Recipes { recipeName = "Rad-X Smoothie", ingredient1 = "Rad-X", ingredient2 = "Milk", ingredient3 = "Mutfruit" },
                            new Recipes { recipeName = "Pepper Steak", ingredient1 = "Meat", ingredient2 = "Pepper", ingredient3 = "Butter" }
                        ];
                        Console.WriteLine("Recipes in the game:\n");
                        foreach (var recipe in recipes)
                        {
                            Console.WriteLine(recipe);
                        }
                        Console.WriteLine("\n-- Press any key to return to the collection menu --");
                        Console.ReadLine();
                        break;

                    case "0":
                        Welcome();
                        break;

                    default:
                        InvalidInput();
                        break;

                }

                Console.Clear();


            } while (userInput != "0");

            Console.WriteLine("Press any key to return to menu");
            Console.ReadLine();

        }

        static void Exit()
        {
            Console.WriteLine("This is the exit");
            Console.WriteLine("Press any key to close program");
            Console.ReadLine();
        }

        public static void InvalidInput()
        {
            Console.WriteLine("Invalid Input");
            Console.ReadLine();
        }

        static void Main()
        {

            string temp;


            do
            {
                Welcome();

                Console.WriteLine("Please choose an option");
                temp = Console.ReadLine();
                Task = Convert.ToInt32(temp);

                Console.Clear();

                switch (Task)

                {
                    case 1:
                        Task1();
                        break;

                    case 2:
                        ArenaMode.Arena();
                        break;

                    case 3:
                        Task3();
                        break;

                    case 0:
                        Exit();
                        break;

                    default:
                        InvalidInput();
                        break;

                }

                Console.Clear();


            } while (Task != 0);




        }
    }
}
