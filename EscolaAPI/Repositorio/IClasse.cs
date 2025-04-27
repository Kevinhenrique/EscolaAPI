using EscolaAPI.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaAPI.Repositorio
{
    public interface IClasse
    {
        Task<List<ClasseModel>> BuscarTodasClasse();

    }
}
