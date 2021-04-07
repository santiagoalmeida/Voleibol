using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Voleibol.BusinessLogic.Logic;
using Voleibol.Models.Data;
using Xunit;

namespace Voleibol.Testing
{
    public class UnitTest1
    {
        private readonly Random _random = new Random();

        [Fact]
        public void TestMatch()
        {
            Match match = new Match
            {
                Team1 = "Test1",
                Team2 = "Test2",
                PointTeam = 0,
                Times = new List<Times>
                {
                    new Times { NumTime = 1, Team1Points = 0, Team2Points = 0 }
                }
            };

            MatchLogic partido = new MatchLogic();
            do
            {
                match.PointTeam = getRnd();
                partido.AddPoint(match);
                partido.CheckSet(match);
            }
            while (!match.Finish);

            string winnerTeam = string.Empty;
            if (match.Times.Sum(c => c.Team1Points) > match.Times.Sum(c => c.Team2Points))
                winnerTeam = match.Team1;
            else
                winnerTeam = match.Team2;

            Assert.Equal(match.Winner, winnerTeam);
        }

        private int getRnd()
        {
            int numero = 0;
            Thread t1 = new Thread(() => numero = new Random().Next(1, 3));
            t1.Start();
            t1.Join();
            return numero;
        }
    }
}
