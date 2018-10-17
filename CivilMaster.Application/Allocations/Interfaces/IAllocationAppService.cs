using CivilMater.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMaster.Application.Allocations.Interfaces
{
    public interface IAllocationAppService
    {
        void Allocate(Allocation allocation);
    }
}
