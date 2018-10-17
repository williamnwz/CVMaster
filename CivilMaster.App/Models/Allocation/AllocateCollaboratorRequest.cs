using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CivilMaster.App.Models.Allocation
{
    public class AllocateCollaboratorRequest
    {
        public string Description { get; protected set; }

        public string IdWork { get; set; }

        public string IdCollaborator { get; set; }

    }
}
