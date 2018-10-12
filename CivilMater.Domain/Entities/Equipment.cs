using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMater.Domain.Entities
{
    public class Equipment : Entity
    {
        public string Name { get; protected set; }

        public string Description { get; protected set; }
    }
}
