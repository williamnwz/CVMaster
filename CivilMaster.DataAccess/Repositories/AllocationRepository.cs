using CivilMater.Domain.Entities;
using CivilMater.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMaster.DataAccess.Repositories
{
    public class AllocationRepository : Repository<Allocation>, IAllocationRepository
    {

        public AllocationRepository(CivilMasterContext context) : base(context)
        {


        }
    }
}
