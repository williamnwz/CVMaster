using AutoMapper;
using CivilMaster.App.Models.Work;
using CivilMaster.Application.Works.Interfaces;
using CivilMater.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace CivilMaster.App.Controllers
{
    [Route("api/Work")]
    public class WorkController : Controller
    {
        private IWorkAppService workAppService;
        private IMapper mapper;

        public WorkController(IWorkAppService workAppService, IMapper mapper)
        {
            this.workAppService = workAppService;
            this.mapper = mapper;
        }


        [HttpPost]
        [Route("CreateWork")]
        public void CreateWork([FromBody]CreateWorkRequest request)
        {
            workAppService.Create(mapper.Map<Work>(request));
        }

        [HttpGet]
        [Route("GetWorks")]
        public IEnumerable<WorkModel> GetWorks()
        {
            return mapper.Map<IEnumerable<WorkModel>>(workAppService.GetWorks());
        }


    }
}