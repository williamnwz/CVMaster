using CivilMaster.DataAccess.Maps;
using CivilMater.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMaster.DataAccess
{
    public class CivilMasterContext : DbContext
    {
        public CivilMasterContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Work> Works { get; set; }
        public DbSet<Collaborator> Collaborators { get; set; }
        public DbSet<Allocation> Allocations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkMap());
            modelBuilder.ApplyConfiguration(new CollaboratorMap());
            modelBuilder.ApplyConfiguration(new AllocationMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
