using System;
using System.Collections.Generic;
using System.Text;

namespace CS155Homework12Aliens
{
    public class OgreAlien : Alien
    {
        //constructors
        public OgreAlien() { }
        public OgreAlien(int h, string n) : base(h, n)
        {
            damage = 6;
        }

        //method to return a baseclass member (protected)
        public int GetDamage() { return damage; }

    }
}
