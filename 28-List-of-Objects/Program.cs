using System;
using System.Collections.Generic;

namespace _28_List_of_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            Player player1 = new Player("Ram");
            Player player2 = new Player("Hari");
            //Player Player3 = new Player("Shyam");

            players.Add(player1);
            players.Add(player2);
            players.Add(new Player("Shyam"));  // Anonymous Object

            foreach (Player p in players)
            {
                // Console.WriteLine(p.name); Not necessary bcz of overrided ToString()
                Console.WriteLine(p);
            }

            Console.ReadKey();

        }
    }

    class Player
    {
        public string name;

        public Player(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
