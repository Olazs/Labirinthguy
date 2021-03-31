using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabrinthGuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Player jatekos = new Player();
            Enemy ellenfel= new Enemy();
            MapHandler map1 = new MapHandler("elso.txt", jatekos);
            weaponswitch wep1 = new weaponswitch();


            bool gameIsRunning = true;
            map1.showMap();
            while (gameIsRunning)
            {

                char command = Console.ReadKey(true).KeyChar;

                Console.Clear();

                switch (command)
                {
                    case 'w': map1.up(); break;
                    case 's': map1.down(); break;
                    case 'a': map1.left(); break;
                    case 'd': map1.right(); break;
                    case 'f': Console.WriteLine(map1.whereAmI()[0] + "|" + map1.whereAmI()[1]); break;
                    case 'e': map1.stats(jatekos); break;
                    case 'q': wep1.weapon_switch(jatekos,ellenfel); break;
                    default: Console.WriteLine("Nincs ilyen parancs!"); break;
                }
                if (map1.GameIsOver)
                {
                    map1.showAndClearMessage();
                    gameIsRunning = false;
                }
                else
                {
                    map1.showMap();
                    map1.showAndClearMessage();
                }
            }

            Console.ReadKey();
        }
    }
}
