using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voleibol.BusinessLogic.Logic;
using Voleibol.Models;
using Voleibol.Models.Data;
using Voleibol.Models.Services;

namespace Voleibol.BusinessLogic.Services
{
    public class PartidoSetService : IPartidoSetService
    {
        MatchLogic partSvc;
        public PartidoSetService()
        {
            partSvc = new MatchLogic();
        }

        public Match AddPoint(Match match)
        {
            partSvc.AddPoint(match);
            return match;
        }

        public Match CheckSet(Match match)
        {
            partSvc.CheckSet(match);
            return match;
        }
    }
}
