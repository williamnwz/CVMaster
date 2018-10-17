using CivilMaster.Application.Allocations.Interfaces;
using CivilMater.Domain.AllocateCollaborators;
using CivilMater.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMaster.Application.Allocations
{
    public class AllocationAppService : IAllocationAppService
    {
        private IAllocateCollaborator allocateCollaborator;

        public AllocationAppService(IAllocateCollaborator allocateCollaborator)
        {
            this.allocateCollaborator = allocateCollaborator;
        }

        public void Allocate(Allocation allocation)
        {
            allocateCollaborator.Allocate(allocation);
        }
    }
}
