using System;
using System.Collections.Generic;
using System.Text;

namespace CS155Homework12Aliens
{
    public class Alien
    {
        private int health; //0 = dead, 100 = full
        private string name;
        protected int damage;

        //constructors
        public Alien()
        {
            damage = 0;
        }
        public Alien(int health, string name)
        {
            this.health = health;//0 = dead, 100 = full
            this.name = name;
            damage = 0;
        }

        public int Health { get => health; set => health = value; }
        public string Name { get => name; set => name = value; }
 
        //method 
        public int GetDamage() { return damage; }

    }
}
