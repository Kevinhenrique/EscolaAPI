using EscolaAPI.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaAPI.Data.Map
{
    public class ClasseMap : IEntityTypeConfiguration<ClasseModel>
    {
        public void Configure(EntityTypeBuilder<ClasseModel> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Classe);
            builder.Property(x => x.Tipo_Ensino);
        }
    }
}
