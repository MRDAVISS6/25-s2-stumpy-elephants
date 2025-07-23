using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberProject
{
    public struct Enemies
    {
        public string enemyName;
        public int enemyHP;
        public int enemyAttack;
        public string enemyDesc;

        public Enemies(string name, int hp, int attack, string desc)
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

    }
}
