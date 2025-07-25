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
            Player player = new Player(charName, 1, "Steel Pan", 6);

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
                Enemies enemy = Program.RadndomHostileEncounter(i);
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
        }
}
