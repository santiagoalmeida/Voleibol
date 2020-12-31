using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voleibol.Models.Data;

namespace Voleibol.BusinessLogic.Logic
{
    public class PartidoSetLogic
    {
        public void AddPoint(IEnumerable<PartidoSet> partidoSet, int IdEquipo)
        {
            PartidoSet partido = partidoSet.OrderByDescending(c => c.NumeroSet).First();

            if (partido.IdEquipo1 == IdEquipo)
                partido.PuntosEquipo1 += 1;
        }

        public void CheckSet(List<PartidoSet> partidoSet)
        {
            PartidoSet partido = partidoSet.OrderByDescending(c => c.NumeroSet).First();
            if(partido.NumeroSet == 5)
            {
                if(partido.PuntosEquipo1 >= 15 || partido.PuntosEquipo2 >= 15)
                {
                    IEnumerable<int> vs = new List<int> { partido.PuntosEquipo1, partido.PuntosEquipo2 };
                    if((vs.OrderBy(c => c).First() - vs.OrderByDescending(c => c).First()) >= 2)
                    {
                        partidoSet.OrderByDescending(c => c.NumeroSet).First().Finalizado = true;
                        
                    }
                }
            }
            else
            {
                if (partido.PuntosEquipo1 >= 25 || partido.PuntosEquipo2 >= 25)
                {
                    IEnumerable<int> vs = new List<int> { partido.PuntosEquipo1, partido.PuntosEquipo2 };
                    if ((vs.OrderBy(c => c).First() - vs.OrderByDescending(c => c).First()) >= 2)
                    {
                        partidoSet.OrderByDescending(c => c.NumeroSet).First().Finalizado = true;
                        partidoSet.Add(new PartidoSet
                        {
                            IdEquipo1 = partidoSet.First().IdEquipo1,
                            IdEquipo2 = partidoSet.First().IdEquipo2,

                        });
                    }
                }
            }
            
        }

    }
}
