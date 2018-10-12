using CivilMaster.Application.Exceptions;
using CivilMaster.Application.Works.Interfaces;
using CivilMater.Domain.CriarObras;
using CivilMater.Domain.Entities;
using CivilMater.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CivilMaster.Application.Works
{
    public class WorkAppService : IWorkAppService
    {
        private ICreateWork createWork;
        private IWorkRepository workRepository;

        public WorkAppService(ICreateWork createWork, IWorkRepository workRepository)
        {
            this.createWork = createWork;
            this.workRepository = workRepository;
        }

        public void Create(Work work)
        {
            if (work == null)
                throw new AppException("Não foi informada uma obra");

            if (string.IsNullOrWhiteSpace(work.Name))
                throw new AppException("Não foi informado um nome para a obra");

            createWork.Create(work);
        }

        public ICollection<Work> GetWorks()
        {
            return workRepository.Find(work => work.Actived).ToList();
        }
    }
}
