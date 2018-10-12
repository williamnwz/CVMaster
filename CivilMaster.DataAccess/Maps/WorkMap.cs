using CivilMater.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CivilMaster.DataAccess.Maps
{
    public class WorkMap : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            builder.ToTable("obra");
            builder.HasKey(work => work.Id);
            builder.Property(work => work.Id).HasColumnName("id");
            builder.Property(work => work.Name).HasColumnName("nome");
            builder.Property(work => work.Description).HasColumnName("descricao");
            builder.Property(work => work.Actived).HasColumnName("ativo");
            builder.Property(work => work.Created).HasColumnName("data_criacao");

            builder
                .HasMany(work => work.Allocations)
                .WithOne(allocation => allocation.Work)
                .HasForeignKey(allocation => allocation.IdWork);


        }
    }
}
