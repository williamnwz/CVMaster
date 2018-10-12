using CivilMater.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMaster.DataAccess.Maps
{
    public class CollaboratorMap : IEntityTypeConfiguration<Collaborator>
    {
        public void Configure(EntityTypeBuilder<Collaborator> builder)
        {
            builder.ToTable("colaborador");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("id");
            builder.Property(c => c.Name).HasColumnName("nome");
            builder.Property(c => c.User).HasColumnName("usuario");
            builder.Property(c => c.Password).HasColumnName("senha");
            builder.Property(a => a.Actived).HasColumnName("ativo");

            builder
                .HasMany(collaborator => collaborator.Allocations)
                .WithOne(allocation => allocation.Collaborator)
                .HasForeignKey(allocation => allocation.IdCollaborator);

        }
    }
}
