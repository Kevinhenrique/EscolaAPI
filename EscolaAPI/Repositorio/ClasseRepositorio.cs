using EscolaAPI.Data;
using EscolaAPI.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaAPI.Repositorio
{
    public class ClasseRepositorio : IClasse
    {
        private readonly AppDbContext _appDb;
        public ClasseRepositorio(AppDbContext appDbContext)
        {
            _appDb = appDbContext;
        }

        public async Task<List<ClasseModel>> BuscarTodasClasse()
        {
            return await _appDb.Classe.ToListAsync();
        }
    }
}
