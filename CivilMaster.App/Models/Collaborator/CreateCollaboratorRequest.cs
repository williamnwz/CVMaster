using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CivilMaster.App.Models.Collaborator
{
    public class CreateCollaboratorRequest
    {
        public string Name { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}
