using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2v2
{
    public class Team : IComparable
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }

        public Team()
        {
            Players = new List<Player>();

        }

        public int TeamPoints()
        {
            int teamPoints = 0;
            foreach (var player in Players)
            {
                teamPoints += player.Calculate();
            }


            //for (int i = 0; i < Players.Count; i++)
            //{
            //    Player player = Players[i];
            //    teamPoints += player.Calculate();
            //}
            return teamPoints;
        }

        public override string ToString()
        {
            int points = TeamPoints();
            return $"{Name} - {points}";
        }

        public int CompareTo(object obj)
        {
            Team otherTeam = obj as Team;

            return this.TeamPoints().CompareTo(otherTeam.TeamPoints());
        }

    }
}
