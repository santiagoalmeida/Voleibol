using System.Collections.Generic;

namespace Voleibol.Models.Data
{
    public class Match
    {
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public List<Times> Times { get; set; }
        public int PointTeam { get; set; }
        public bool Finish { get; set; }
        public string Winner { get; set; }
    }
}
