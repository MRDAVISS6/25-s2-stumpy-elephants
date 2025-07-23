using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberProject
{
    public struct Enemy
    {
        public string enemyName;
        public int enemyHP;
        public int enemyAttack;
        public string enemyDesc;

        public Enemy(string name, int hp, int attack, string desc)
        {
            this.enemyName = name;
            this.enemyHP = hp;
            this.enemyAttack = attack;
            this.enemyDesc = desc;
        }

        public override string ToString()
        {
            return $"{enemyName} | HP: {enemyHP} | Attack: {enemyAttack} | Description: {enemyDesc}";
        }

        // Static methods/variables used for monster creation

        public static Enemy[] storyModeMonsters =
        {
            new Enemy("Mirelurk", 30, 5, "A mutated crab-like creature with a hard shell and a vicious bite."),
            new Enemy("Super Mutant", 40, 8, "A hulking brute with enhanced strength and resilience, often armed with heavy weapons."),
            new Enemy("Deathclaw", 50, 10, "A terrifying predator with razor-sharp claws and incredible speed."),
            new Enemy("Radscorpion", 65, 13, "A giant scorpion with a venomous sting and armored exoskeleton."),
            new Enemy("Radroach", 20, 4, "Giant irradiated cockroach with acidic saliva and armored carapace"),
            new Enemy("Mutant Hound", 35, 7, "Once a domestic dog, now a grotesque, hairless predator with enhanced senses and aggression."),
            new Enemy("Ash Crawler", 25, 5, "A pale, skeletal creature that burrows through radioactive ash, ambushing prey from below."),
            new Enemy("Ghoul Reaper", 30, 6, "A sentient, decaying humanoid that hunts the living for flesh, often in packs."),
            new Enemy("Wasteland Abomination", 50, 10, "A massive fusion of flesh and machinery, created from failed experiments and scavenged tech."),
            new Enemy("Irradiated Behemoth", 60, 12, "Towering brute pulsing with nuclear energy, leaving scorched earth in its wake."),
            new Enemy("Scorched Stalker", 28, 6, "Burn-scarred humanoid with smoldering skin, capable of setting traps and ambushes."),
            new Enemy("Toxic Spitter", 22, 5, "A bloated mutant that expels corrosive bile from a distended jaw."),
            new Enemy("Bone Dragger", 26, 5, "Lurks in the shadows, dragging scavenged bones across the ground to lure victims."),
            new Enemy("Nuke Leech", 18, 3, "A glowing, slug-like parasite that feeds on radiation and attaches to living hosts."),
            new Enemy("Murderous Crow", 22, 4, "A seemingly normal crow with teeth that can cut through ceramic plates"),
            new Enemy("Mutant Bear", 35, 8, "A mutated bear, aggressive and dangerous.")
        };
        public static Enemy RandomArenaEnemy(int i)
        {
            int modifier = i * 2;
            Enemy[] monsters =
            {
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
            };
            Random rand = new Random();
            int enemyNumber = rand.Next(monsters.Length);

            return monsters[enemyNumber];
        }
    }
}
