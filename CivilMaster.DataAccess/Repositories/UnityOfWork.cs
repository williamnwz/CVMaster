using CivilMater.Domain.Entities;
using CivilMater.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMaster.DataAccess.Repositories
{
    public class UnityOfWork : Repository<Entity>, IUnityOfWork
    {
        public UnityOfWork(CivilMasterContext context) : base(context)
        {
        }
    }
}
