using EscolaAPI.Data;
using EscolaAPI.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaAPI.Repositorio
{
    public class AlunoRepositorio : IAluno
    {
        private readonly AppDbContext _appDb;
        public AlunoRepositorio(AppDbContext appDbContext)
        {
            _appDb = appDbContext;
        }

        public async Task<AlunoModel> AdicionarAluno(AlunoModel alunoModel)
        {
            if (CpfValido(alunoModel.Cpf))
            {
                try
                {
                    await _appDb.Aluno.AddAsync(alunoModel);
                    await _appDb.SaveChangesAsync();
                    return alunoModel;
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                throw new Exception("O Aluno " + alunoModel.Nome + " não está com o cpf valido!");
            }

        }

        public async Task<AlunoModel> AtualizarAluno(AlunoModel alunoModel)
        {
            AlunoModel aluno = new AlunoModel();
            aluno = await BuscarPorAlunoId(alunoModel.Id);

            if(aluno == null)
            {
                throw new Exception("O Aluno " + alunoModel.Nome + " não foi encontrado!");
            }

            aluno.Email = alunoModel.Email;
            aluno.Telefone = alunoModel.Telefone;
            aluno.Endereco = alunoModel.Endereco;
            aluno.Bairro = alunoModel.Bairro;
            aluno.Cidade = alunoModel.Cidade;
            aluno.Estado = alunoModel.Estado;
            aluno.Rua = alunoModel.Rua;
            aluno.Complemento = alunoModel.Complemento;

            try
            {
                _appDb.Aluno.Update(aluno);
                await _appDb.SaveChangesAsync();
                return aluno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<AlunoModel> BuscarPorAlunoId(int id)
        {
            try
            {
                return await _appDb.Aluno.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<AlunoModel>> BuscarTodosOsAlunos()
        {
            try
            {
                return await _appDb.Aluno.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> ExcluirAluno(int id)
        {
            AlunoModel aluno = await BuscarPorAlunoId(id);

            if (aluno == null)
            {
                throw new Exception("O Aluno da matricula: " + id + " não foi encontrado!");
            }

            try
            {
                _appDb.Aluno.Remove(aluno);
                await _appDb.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool CpfValido(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}
