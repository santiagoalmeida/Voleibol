using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Voleibol.Models.Data;
using Voleibol.Models.Services;

namespace Voleibol.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PuntosController : ControllerBase
    {

        private readonly ILogger<PuntosController> _logger;
        private readonly IPartidoSetService _partidoSvc;

        public PuntosController(ILogger<PuntosController> logger, IPartidoSetService partidoSvc)
        {
            _logger = logger;
            _partidoSvc = partidoSvc;
        }

        [HttpPost]
        [Route("AddPoint")]
        public Match post(Match match)
        {
            return _partidoSvc.AddPoint(match);
        }

        [HttpPost]
        [Route("CheckSet")]
        public Match CheckSet(Match match)
        {
            _partidoSvc.CheckSet(match);
            return match;
        }
    }
}
