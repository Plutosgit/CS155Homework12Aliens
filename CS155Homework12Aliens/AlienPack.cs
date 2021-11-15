using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CS155Homework12Aliens
{
    class AlienPack
    {
        private int maxcount;
        private ArrayList alPack;

        //constructors
        public AlienPack() {
            alPack = new ArrayList();        
        }
        public AlienPack(int maxcount)
        {
            this.maxcount = maxcount;
            alPack = new ArrayList();
        }

        public int MaxCount { get => maxcount ; set => maxcount = value; }

        public int CalculateDamage()
        {
            int totaldamage = 0;

            foreach (var val in alPack)
            {
                totaldamage += ((Alien)val).GetDamage();

            }
            return totaldamage;
        }

        public void AddAlien(Object a)
        {
            alPack.Add(a);

        }
        public ArrayList GetAliens()
        {
            return alPack;
        }

    }
}
