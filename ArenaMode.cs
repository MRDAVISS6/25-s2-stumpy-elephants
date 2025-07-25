using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlavoursOfFallout
{
    internal class ArenaMode
    {
        public static void Arena()
        {
            int i = 1;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to the Arena Maggot!");
            Thread.Sleep(1000);
            Console.WriteLine("This world ain't for the weak!");
            Thread.Sleep(1000);
            Console.WriteLine("Survive for as long as you can in the Arena and prove your worth!\n");
            Thread.Sleep(1000);

            Console.WriteLine("Enter the name of your character.");
            string charName = Console.ReadLine();
            Player player = new Player(charName, 100, "Steel Pan", 6);

            Console.ResetColor();

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Round {i++}");
                Console.ResetColor();
                Thread.Sleep(2000);

                Console.Clear();
                Enemy enemy = RandomArenaEnemy(i);
                Program.CombatSystem(ref player, enemy);
                if (player.playerHP <= 0)
                {
                    Console.WriteLine("You have been defeated in the Arena. Game Over!");
                    Console.WriteLine($"You survived for {i - 1} rounds.");
                    Console.WriteLine("Press Enter to exit...");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine($"You have defeated the {enemy.enemyName}!");
                    Thread.Sleep(1000);
                    Program.AcquireEpicLoot();
                }

                Console.Clear();
            } while (player.playerHP > 0);
        }

        public static Enemy RandomArenaEnemy(int i)
        {
            int modifier = i * 2;
            List<Enemy> monsters =
            [
                new Enemy("Mirelurk", 4*modifier, 7, "A mutated crab-like creature with a hard shell and a vicious bite."),
                new Enemy("Super Mutant",3*modifier , 8, "A hulking brute with enhanced strength and resilience, often armed with heavy weapons."),
                new Enemy("Deathclaw", 5*modifier, 10, "A terrifying predator with razor-sharp claws and incredible speed."),
                new Enemy("Radscorpion", 2*modifier, 7, "A giant scorpion with a venomous sting and armored exoskeleton."),
                new Enemy("Radroach", 2*modifier, 4, "Giant irradiated cockroach with acidic saliva and armored carapace"),
                new Enemy("Mutant Hound", 3*modifier, 7, "Once a domestic dog, now a grotesque, hairless predator with enhanced senses and aggression."),
                new Enemy("Ash Crawler", 2*modifier, 5, "A pale, skeletal creature that burrows through radioactive ash, ambushing prey from below."),
                new Enemy("Ghoul Reaper", 3*modifier, 6, "A sentient, decaying humanoid that hunts the living for flesh, often in packs."),
                new Enemy("Wasteland Abomination", 5*modifier, 10, "A massive fusion of flesh and machinery, created from failed experiments and scavenged tech."),
                new Enemy("Irradiated Behemoth", 6*modifier, 11, "Towering brute pulsing with nuclear energy, leaving scorched earth in its wake."),
                new Enemy("Scorched Stalker", 3*modifier, 6, "Burn-scarred humanoid with smoldering skin, capable of setting traps and ambushes."),
                new Enemy("Toxic Spitter", 2*modifier, 5, "A bloated mutant that expels corrosive bile from a distended jaw."),
                new Enemy("Bone Dragger", 3*modifier, 5, "Lurks in the shadows, dragging scavenged bones across the ground to lure victims."),
                new Enemy("Nuke Leech", 2*modifier, 5, "A glowing, slug-like parasite that feeds on radiation and attaches to living hosts."),
                new Enemy("Murderous Crow", 2*modifier, 4, "A seemingly normal crow with teeth that can cut through ceramic plates")
            ];
            Random rand = new Random();
            int enemyNumber = rand.Next(monsters.Count);

            return monsters[enemyNumber];
        }

    }
}
