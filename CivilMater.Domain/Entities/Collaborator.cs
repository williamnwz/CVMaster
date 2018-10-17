using CivilMater.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CivilMater.Domain.Entities
{
    public class Collaborator : Entity
    {
        public string Name { get; protected set; }

        public string User { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }


        public virtual ICollection<Profile> Profiles { get; protected set; }

        public virtual ICollection<Allocation> Allocations { get; protected set; }


        public void Allocate(Work work)
        {
            if (this.Allocations == null || this.Allocations.Any() == false)
                this.Allocations = new List<Allocation>();

            if (this.Allocations.Any(x => x.Work.Id == work.Id))
                throw new DomainException($@"O colaborador {this.Name} já está alocado na obra {work.Name}");

            Allocation allocation = new Allocation();
            allocation.Enable();
            allocation.Collaborator = this;
            this.Allocations.Add(allocation);
        }

        public void Enable()
        {
            CreateId();
            Active();
        }

    }
}
