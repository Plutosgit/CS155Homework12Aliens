using System;
using System.Collections.Generic;
using System.Text;

namespace CS155Homework12Aliens
{
    public class MarshallowManAlien : Alien
    {
        //constructors
        public MarshallowManAlien() { }
        public MarshallowManAlien(int h, string n) : base(h, n)
        {
            damage = 1;
        }

        //method to return a baseclass member (protected)
        public int GetDamage() { return damage; }


    }
}
