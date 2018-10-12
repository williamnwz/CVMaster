using CivilMater.Domain.Entities;
using CivilMater.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMaster.DataAccess.Repositories
{
    public class WorkRepository : Repository<Work>, IWorkRepository
    {
        public WorkRepository(CivilMasterContext context) : base(context)
        {

        }
    }
}
