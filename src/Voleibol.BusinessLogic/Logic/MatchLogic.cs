using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voleibol.Models.Data;

namespace Voleibol.BusinessLogic.Logic
{
    public class MatchLogic
    {
        public void AddPoint(Match match)
        {
            if (match.Times.Where(c => !c.Terminado).Any())
            {
                if (match.PointTeam == 1)
                    match.Times.SingleOrDefault(c => !c.Terminado).Team1Points += 1;
                if (match.PointTeam == 2)
                    match.Times.SingleOrDefault(c => !c.Terminado).Team2Points += 1;
            }
        }

        public void CheckSet(Match match)
        {
            if(match.Times.Count <= 5 && match.Times.Where(c => !c.Terminado).Any())
            {
                if ((match.Times.SingleOrDefault(c => !c.Terminado).Team1Points >= 25 && match.Times.SingleOrDefault(c => !c.Terminado).Team1Points >= match.Times.SingleOrDefault(c => !c.Terminado).Team2Points + 2) ||
                    (match.Times.SingleOrDefault(c => !c.Terminado).Team2Points >= 25 && match.Times.SingleOrDefault(c => !c.Terminado).Team2Points >= match.Times.SingleOrDefault(c => !c.Terminado).Team1Points + 2))
                {
                    match.Times.SingleOrDefault(c => !c.Terminado).Terminado = true;
                    if (match.Times.Count <= 4)
                        match.Times.Add(new Times { Team1Points = 0, Team2Points = 0, Terminado = false, NumTime = match.Times.Max(c => c.NumTime) + 1 });
                }
            }
            else
            {
                match.Finish = true;
                if (match.Times.Sum(c => c.Team1Points) > match.Times.Sum(c => c.Team2Points))
                    match.Winner = match.Team1;
                else
                    match.Winner = match.Team2;
            }
        }

    }
}
