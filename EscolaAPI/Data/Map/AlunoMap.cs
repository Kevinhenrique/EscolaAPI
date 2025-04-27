using EscolaAPI.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaAPI.Data.Map
{
    public class AlunoMap : IEntityTypeConfiguration<AlunoModel>
    {
        public void Configure(EntityTypeBuilder<AlunoModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome);
            builder.Property(x => x.Data_Nascimento);
            builder.Property(x => x.Cpf);
            builder.Property(x => x.Email);
            builder.Property(x => x.Endereco);
            builder.Property(x => x.Sexo);
            builder.Property(x => x.Rua);
            builder.Property(x => x.Telefone);
            builder.Property(x => x.Estado);
            builder.Property(x => x.Bairro);
            builder.Property(x => x.Rua);
            builder.Property(x => x.Id_Classe);
        }
    }
}
