using CivilMaster.Application.Works.Interfaces;
using CivilMater.Domain.Entities;
using CivilMater.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMaster.Application.Decorators
{
    public class WorkAppServiceTransactionDecorator : IWorkAppService
    {
        private IWorkAppService workAppService;
        private IUnityOfWork unityOfWork;

        public WorkAppServiceTransactionDecorator(IWorkAppService workAppService,
            IUnityOfWork unityOfWork)
        {
            this.workAppService = workAppService;
            this.unityOfWork = unityOfWork;
        }

        public void Create(Work work)
        {
            workAppService.Create(work);

            unityOfWork.Commit();
        }

        public ICollection<Work> GetWorks()
        {
            return workAppService.GetWorks();
        }
    }
}
