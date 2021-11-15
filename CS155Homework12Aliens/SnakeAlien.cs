using System;
using System.Collections.Generic;
using System.Text;

namespace CS155Homework12Aliens
{
    public class SnakeAlien:Alien
    {
        //constructors
        public SnakeAlien() { }
        public SnakeAlien(int h, string n) : base(h, n)
        {
            damage = 10;
        }

        //method to return a baseclass member (protected)
        public int GetDamage() { return damage; }
    }
}
