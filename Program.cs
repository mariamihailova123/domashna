using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДР
{
    class Program
    {
        static void Main(string[] args)
        {

            var player1 = new Goalkeeper { Name = "John", Age = 25, Number = 1, Height = 180 };
            var player2 = new Defender { Name = "Mike", Age = 28, Number = 5, Height = 185 };
            var player3 = new Midfielder { Name = "Sarah", Age = 23, Number = 10, Height = 170 };
            var player4 = new Striker { Name = "David", Age = 26, Number = 9, Height = 175 };

            var coach = new Coach { Name = "Alex", Age = 45 };

            var team1 = new Team { Coach = coach, Players = new List<FootballPlayer> { player1, player2, player3, player4 } };

            var player5 = new Goalkeeper { Name = "Emily", Age = 24, Number = 1, Height = 175 };
            var player6 = new Defender { Name = "Tom", Age = 29, Number = 4, Height = 190 };
            var player7 = new Midfielder { Name = "Chris", Age = 22, Number = 8, Height = 180 };
            var player8 = new Striker { Name = "Sophia", Age = 27, Number = 11, Height = 165 };

            var coach2 = new Coach { Name = "Steve", Age = 42 };

            var team2 = new Team { Coach = coach2, Players = new List<FootballPlayer> { player5, player6, player7, player8 } };

            var referee = new Referee { Name = "Mark", Age = 35 };

            var goal1 = new Goal { Minute = 20, Player = player3 };
            var goal2 = new Goal { Minute = 10, Player = player2 };
        }
    }
}
