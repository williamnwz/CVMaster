using CivilMater.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMater.Domain.AllocateCollaborators
{
    public interface IAllocateCollaborator
    {
        void Allocate(Allocation allocation);

    }
}
