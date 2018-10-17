using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CivilMater.Domain.Entities;
using CivilMater.Domain.Exceptions;
using CivilMater.Domain.Repositories;

namespace CivilMater.Domain.CreateCollaborator
{
    public class CreateCollaborator : ICreateCollaborator
    {
        private ICollaboratorRepository collaboratorRepository;

        public CreateCollaborator(ICollaboratorRepository collaboratorRepository, IUnityOfWork unityOfWork)
        {
            this.collaboratorRepository = collaboratorRepository;
        }

        public void Create(Collaborator collaborator)
        {

            if (collaborator == null)
                throw new DomainException($@"Não foi informado um colaborador!");

            if (string.IsNullOrWhiteSpace(collaborator.Name))
                throw new DomainException($@"Não foi informado o nome do colaborador!");

            ICollection<Collaborator> collaborators = collaboratorRepository.Find(x => x.Name.ToUpper().Equals(collaborator.Name.ToUpper()));

            if (collaborators.Any(x => x.Actived))
                throw new DomainException($@"Já existe o colaborador {collaborator.Name}");

            collaborator.Enable();

            collaboratorRepository.Save(collaborator);

        }
    }
}
