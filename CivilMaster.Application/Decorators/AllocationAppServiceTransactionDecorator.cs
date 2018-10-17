using CivilMaster.Application.Allocations;
using CivilMaster.Application.Allocations.Interfaces;
using CivilMater.Domain.Entities;
using CivilMater.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMaster.Application.Decorators
{
    public class AllocationAppServiceTransactionDecorator : IAllocationAppService
    {
        private IAllocationAppService allocationAppService;
        private IUnityOfWork unityOfWork;


        public AllocationAppServiceTransactionDecorator(IAllocationAppService allocationAppService, 
            IUnityOfWork unityOfWork)
        {
            this.allocationAppService = allocationAppService;
            this.unityOfWork = unityOfWork;
        }

        public void Allocate(Allocation allocation)
        {
            allocationAppService.Allocate(allocation);

            unityOfWork.Commit();
        }
    }
}
