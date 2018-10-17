using CivilMaster.Application.Collaborators.Interfaces;
using CivilMater.Domain.Entities;
using CivilMater.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMaster.Application.Decorators
{
    public class CollaboratorAppServiceTransactionDecorator : ICollaboratorAppService
    {

        private ICollaboratorAppService collaboratorAppService;
        private IUnityOfWork unityOfWork;

        public CollaboratorAppServiceTransactionDecorator(ICollaboratorAppService collaboratorAppService,
            IUnityOfWork unityOfWork)
        {
            this.collaboratorAppService = collaboratorAppService;
            this.unityOfWork = unityOfWork;
        }

        public void CreateCollaborator(Collaborator collaborator)
        {
            collaboratorAppService.CreateCollaborator(collaborator);

            unityOfWork.Commit();
        }
    }
}
