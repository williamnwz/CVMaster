using CivilMater.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMaster.DataAccess.Maps
{
    public class AllocationMap : IEntityTypeConfiguration<Allocation>
    {
        public void Configure(EntityTypeBuilder<Allocation> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("id");
            builder.Property(a => a.IdCollaborator).HasColumnName("id_colaborador");
            builder.Property(a => a.IdWork).HasColumnName("id_obra");
            builder.Property(a => a.Description).HasColumnName("descricao");
            builder.Property(a => a.Created).HasColumnName("data_criacao");
            builder.Property(a => a.End).HasColumnName("data_fim");
            builder.Property(a => a.Actived).HasColumnName("ativo");

        }
    }
}
