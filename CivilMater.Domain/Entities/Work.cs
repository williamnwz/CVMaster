using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMater.Domain.Entities
{
    public class Work : Entity
    {
        public string Name { get; protected set; }

        public string Description { get; protected set; }

        public DateTime Created { get; protected set; }

        public ICollection<Allocation> Allocations { get; protected set; }

        public ICollection<Activity> Activities { get; set; }

        public ICollection<Budget> Budgets { get; set; }

        public void EnableWork()
        {
            CreateId();
            Active();
            Created = DateTime.Now;
        }
    }
}
