using AutoMapper;
using CivilMaster.App.Models.Allocation;
using CivilMaster.App.Models.Collaborator;
using CivilMaster.App.Models.Work;
using CivilMaster.Application.Allocations.Interfaces;
using CivilMaster.Application.Collaborators.Interfaces;
using CivilMaster.Application.Works.Interfaces;
using CivilMater.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace CivilMaster.App.Controllers
{
    [Route("api/Allocation")]
    public class AllocationController : Controller
    {

        private IMapper mapper;
        private IAllocationAppService allocationAppService;

        public AllocationController(IAllocationAppService allocationAppService,
            IMapper mapper)
        {
            this.allocationAppService = allocationAppService;
            this.mapper = mapper;
        }


        [HttpPost]
        [Route("AllocateCollaborator")]
        public void AllocateCollaborator([FromBody]AllocateCollaboratorRequest request)
        {
            allocationAppService.Allocate(mapper.Map<Allocation>(request));
        }
    }
}
