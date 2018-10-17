using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CivilMater.Domain.CreateCollaborator;
using CivilMater.Domain.Entities;
using CivilMater.Domain.Exceptions;
using CivilMater.Domain.Repositories;

namespace CivilMater.Domain.AllocateCollaborators
{
    public class AllocateCollaborator : IAllocateCollaborator
    {
        private ICollaboratorRepository collaboratorRepository;
        private IWorkRepository workRepository;
        private ICreateCollaborator createCollaborator;
        private IAllocationRepository allocationRepository;


        public AllocateCollaborator(ICollaboratorRepository collaboratorRepository,
            IWorkRepository workRepository,
            ICreateCollaborator createCollaborator,
            IAllocationRepository allocationRepository)
        {
            this.collaboratorRepository = collaboratorRepository;
            this.workRepository = workRepository;
            this.allocationRepository = allocationRepository;
            this.createCollaborator = createCollaborator;
        }


        private void Vaidate(Allocation allocation)
        {
            if (allocation == null)
                throw new DomainException($@"Não foi informada nenhuma alocação!");

            allocation.Collaborator = this.collaboratorRepository.Find(x => x.Id.Equals(allocation.IdCollaborator)).FirstOrDefault();

            if (allocation.Collaborator == null)
                throw new DomainException($@"Não foi informado nenhum colaborador!");

            allocation.Work = this.workRepository.Find(x => x.Id.Equals(allocation.IdWork)).FirstOrDefault();

            if (allocation.Work == null)
                throw new DomainException($@"Não foi informada nenhuma obra para alocar o colaborador!");
        }

        public void Allocate(Allocation allocation)
        {
            Vaidate(allocation);

            allocation.Enable();

            allocationRepository.Save(allocation);
        }


    }
}
