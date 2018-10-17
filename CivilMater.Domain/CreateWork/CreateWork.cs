using CivilMater.Domain.AllocateCollaborators;
using CivilMater.Domain.Entities;
using CivilMater.Domain.Exceptions;
using CivilMater.Domain.Repositories;
using System.Linq;

namespace CivilMater.Domain.CriarObras
{
    public class CreateWork : ICreateWork
    {
        private IWorkRepository workRepositiory;
        public CreateWork(IWorkRepository workRepositiory, 
            IAllocateCollaborator allocateCollaborator) {

            this.workRepositiory = workRepositiory;
        }

        public void Create(Work work)
        {
            bool anyWork = workRepositiory.Find(x => x.Name.ToUpper().Equals(work.Name.ToUpper())).Any();

            if (anyWork)
                throw new DomainException("Já existe uma obra com o nome informado");

            work.EnableWork();

            workRepositiory.Save(work);

        }
    }
}
