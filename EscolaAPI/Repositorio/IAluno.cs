using EscolaAPI.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaAPI.Repositorio
{
    public interface IAluno
    {
        Task<List<AlunoModel>> BuscarTodosOsAlunos();
        Task<AlunoModel> BuscarPorAlunoId(int id);
        Task<AlunoModel> AtualizarAluno(AlunoModel alunoModel);
        Task<AlunoModel> AdicionarAluno(AlunoModel alunoModel);
        Task<bool> ExcluirAluno(int id);

    }
}
