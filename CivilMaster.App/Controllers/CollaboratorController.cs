using AutoMapper;
using CivilMaster.App.Models.Collaborator;
using CivilMaster.App.Models.Work;
using CivilMaster.Application.Collaborators.Interfaces;
using CivilMaster.Application.Works.Interfaces;
using CivilMater.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace CivilMaster.App.Controllers
{
    [Route("api/Collaborator")]
    public class CollaboratorController : Controller
    {
        private ICollaboratorAppService collaboratorAppService;
        private IMapper mapper;

        public CollaboratorController(ICollaboratorAppService collaboratorAppService, IMapper mapper)
        {
            this.collaboratorAppService = collaboratorAppService;
            this.mapper = mapper;
        }

        [HttpPost]
        [Route("CreateCollaborator")]
        public void CreateWork([FromBody]CreateCollaboratorRequest request)
        {
            collaboratorAppService.CreateCollaborator(mapper.Map<Collaborator>(request));
        }

    }
}
