using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Voleibol.Models.Comun;

namespace Voleibol.Models.Data
{
    public class Equipo
    {
        [Key]
        public int IdEquipo { get; set; }
        [Required]
        [MaxLength(Constantes.LongitudNombres)]
        public string NombreEquipo { get; set; }
        public IEnumerable<PartidoSet> Equipos1 { get; set; }
        public IEnumerable<PartidoSet> Equipos2 { get; set; }
    }
}
