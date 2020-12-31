using System.ComponentModel.DataAnnotations;

namespace Voleibol.Models.Data
{
    public class PartidoSet
    {
        [Key]
        public int IdPartidoSet { get; set; }
        public int IdEquipo1 { get; set; }
        public Equipo Equipo1 { get; set; }
        public int PuntosEquipo1 { get; set; }
        public bool ServicioEquipo1 { get; set; }
        public int IdEquipo2 { get; set; }
        public Equipo Equipo2 { get; set; }
        public int PuntosEquipo2 { get; set; }
        public bool ServicioEquipo2 { get; set; }
        public int NumeroSet { get; set; }
        public bool Finalizado { get; set; }
    }
}
