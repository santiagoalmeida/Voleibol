using System.ComponentModel.DataAnnotations;

namespace Voleibol.Models.Data
{
    public class Times
    {
        public int NumTime { get; set; }
        public int Team1Points { get; set; }
        public int Team2Points { get; set; }
        public bool Terminado { get; set; }
    }
}
