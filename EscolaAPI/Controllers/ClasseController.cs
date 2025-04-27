using EscolaAPI.Modelos;
using EscolaAPI.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaAPI.Controllers
{
    [ApiController]
    [Route("classe")]

    public class ClasseController : ControllerBase
    {
        private readonly IClasse _classe;
        public ClasseController(IClasse classe)
        {
            _classe = classe;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClasseModel>>> BuscarClasses()
        {
            List<ClasseModel> classes = await _classe.BuscarTodasClasse();
            return Ok(classes);
        }
    }
}
