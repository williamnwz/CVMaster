using CivilMater.Domain.Entities;
using CivilMater.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CivilMaster.DataAccess.Repositories
{
    public class CollaboratorRepository : Repository<Collaborator> , ICollaboratorRepository
    {

        public CollaboratorRepository(CivilMasterContext context) : base(context)
        {
        }

    }
}
