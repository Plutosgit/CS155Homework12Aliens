using System;

namespace CS155Homework12Aliens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Aliens! Homework 12");
            Console.WriteLine();
            Console.WriteLine("Creating Aliens..");

            Alien a = new Alien( 100, "Bigboy");
            Alien b = new Alien(75, "Modboy");
            Alien c = new Alien(0, "Deadboy");

            SnakeAlien sa = new SnakeAlien(100, "Zzzzz");
            SnakeAlien sb = new SnakeAlien(50, "ppssss");

            OgreAlien oa = new OgreAlien(35, "Oggi");
            OgreAlien ob = new OgreAlien(65, "Ozzi");

            MarshallowManAlien ma = new MarshallowManAlien(42, "Mama");
            MarshallowManAlien mb = new MarshallowManAlien(84, "Mimi");

            Console.WriteLine("Adding Aliens to AlienPack..");
            AlienPack myAlienPack = new AlienPack(20);
            myAlienPack.AddAlien(a);
            myAlienPack.AddAlien(b);
            myAlienPack.AddAlien(c);
            myAlienPack.AddAlien(sa);
            myAlienPack.AddAlien(sb);
            myAlienPack.AddAlien(oa);
            myAlienPack.AddAlien(ob);
            myAlienPack.AddAlien(ma);
            myAlienPack.AddAlien(mb);

            Console.WriteLine("Calculating damage by the Alien Pack..");
            int Fulldamage = myAlienPack.CalculateDamage();

            Console.WriteLine();
            Console.WriteLine("Report out");
            Console.WriteLine("----------");
            Console.Write("Number of Aliens added...... ");
            Console.WriteLine(myAlienPack.GetAliens().Count);
            Console.Write("Damage by the Alien Pack.... " + Fulldamage.ToString());

            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
