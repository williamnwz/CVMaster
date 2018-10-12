using CivilMater.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMater.Domain.CreateCollaborator
{
    public interface ICreateCollaborator
    {

        void Create(Collaborator collaborator);
    }
}
