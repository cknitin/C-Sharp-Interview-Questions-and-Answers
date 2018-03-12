using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo2
{

    class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Team:IEnumerable
    {
        private Player[] players = new Player[5];

        public Team()
        {
            players[0] = new Player { Name="Maxwell", Age= 23 };
            players[1] = new Player { Name = "Root", Age = 21 };
            players[2] = new Player { Name = "AB D", Age = 30 };
            players[3] = new Player { Name = "MSD", Age = 35 };
            players[4] = new Player { Name = "P Shaw", Age = 18 };
        }

        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();

            foreach (Player player in team)
            {
                Console.WriteLine(player.Name);
            }

            Console.ReadLine();
        }
    }
}
