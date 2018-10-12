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
        private IUnityOfWork unityOfWork;


        public AllocateCollaborator(ICollaboratorRepository collaboratorRepository,
            IWorkRepository workRepository,
            ICreateCollaborator createCollaborator,
            IAllocationRepository allocationRepository,
            IUnityOfWork unityOfWork)
        {
            this.collaboratorRepository = collaboratorRepository;
            this.workRepository = workRepository;
            this.allocationRepository = allocationRepository;
            this.unityOfWork = unityOfWork;
        }


        private void Vaidate(Allocation allocation)
        {
            if (allocation == null)
                throw new DomainException($@"Não foi informada nenhuma alocação!");

            if (allocation.Collaborator == null)
                throw new DomainException($@"Não foi informado nenhum colaborador!");

            if (allocation.Work == null)
                throw new DomainException($@"Não foi informada nenhuma obra para alocar o colaborador!");


        }

        public void Allocate(Allocation allocation)
        {
            Vaidate(allocation);

            Collaborator collaborator = collaboratorRepository
                .Find(x => x.Name.ToUpper().Equals(allocation.Collaborator.Name.ToUpper()))
                .FirstOrDefault();

            // Colaborador ja cadastrado
            if (collaborator != null)
            {
                allocation.Collaborator = collaborator;
            }
            else
            {
                createCollaborator.Create(allocation.Collaborator);

                Collaborator novoColaborador = collaboratorRepository
                    .Find(x => x.Name.ToUpper().Equals(allocation.Collaborator.Name.ToUpper()))
                    .FirstOrDefault();

                allocation.Collaborator = novoColaborador;
            }
                
            Work work = workRepository
                .Find(x => x.Id.Equals(allocation.Work.Id))
                .FirstOrDefault();

            if (work == null)
                throw new DomainException($@"Foi informada uma obra inválida!");

            allocationRepository.Save(allocation);

            unityOfWork.Commit();

        }


    }
}
