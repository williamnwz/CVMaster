using CivilMater.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMaster.Application.Works.Interfaces
{
    public interface IWorkAppService
    {
        void Create(Work work);

        ICollection<Work> GetWorks();
    }
}
