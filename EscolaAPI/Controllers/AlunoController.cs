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
    [Route("aluno")]

    public class AlunoController : ControllerBase
    {
        private readonly IAluno _alunoInterface;
        public AlunoController(IAluno alunoInterface)
        {
            _alunoInterface = alunoInterface;
        }

        [HttpGet]
        public async Task<ActionResult<List<AlunoModel>>> BuscarAlunos()
        {
            List<AlunoModel> alunos = await _alunoInterface.BuscarTodosOsAlunos();
            return Ok(alunos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AlunoModel>> BuscarAlunoPorId(int id)
        {
            AlunoModel aluno = await _alunoInterface.BuscarPorAlunoId(id);
            return Ok(aluno);
        }

        [HttpPost]
        public async Task<ActionResult<AlunoModel>> Cadastrar([FromBody] AlunoModel alunoModel)
        {
            AlunoModel aluno =  await _alunoInterface.AdicionarAluno(alunoModel);
            return Ok(aluno);
        }

        [HttpPut]
        public async Task<ActionResult<AlunoModel>> AtualizarCadastro([FromBody] AlunoModel alunoModel)
        {
            AlunoModel aluno = await _alunoInterface.AtualizarAluno(alunoModel);
            return Ok(aluno);
        }

        [HttpDelete]
        public async Task<ActionResult<bool>> ExcluirCadastro(int id)
        {
            return await _alunoInterface.ExcluirAluno(id);
        }
    }
}
