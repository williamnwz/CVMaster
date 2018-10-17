using CivilMaster.Application.Collaborators.Interfaces;
using CivilMater.Domain.CreateCollaborator;
using CivilMater.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMaster.Application.Collaborators
{
    public class CollaboratorAppService : ICollaboratorAppService
    {
        private ICreateCollaborator createCollaborator;

        public CollaboratorAppService(ICreateCollaborator createCollaborator)
        {
            this.createCollaborator = createCollaborator;
        }

        public void CreateCollaborator(Collaborator collaborator)
        {
            createCollaborator.Create(collaborator);
        }
    }
}
