using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMater.Domain.Entities
{
    public class Allocation : Entity
    {
        public DateTime Created { get; protected set; }

        public DateTime End { get; protected set; }

        public string Description { get; protected set; }

        public string IdWork { get; set; }

        public Work Work { get; set; }

        public string IdCollaborator { get; set; }

        public Collaborator Collaborator { get; set; }

        public void Enable()
        {
            CreateId();
            Active();
            this.Created = DateTime.Now;
        }

   
    }
}
