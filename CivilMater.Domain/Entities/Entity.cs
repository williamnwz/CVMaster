using System;

namespace CivilMater.Domain.Entities
{
    public abstract class Entity
    {
        public string Id { get; protected set; }

        public bool Actived { get; protected set; }

        public void CreateId()
        {
            this.Id = Guid.NewGuid().ToString("N");
        }

        public void Active()
        {
            this.Actived = true;
        }
    }
}
