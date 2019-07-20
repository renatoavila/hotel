using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Domain.Entity
{
    public abstract class Entity : IEntity
    {
        public Entity()
        {
            Key = Guid.NewGuid();
        }
        public int Id { get; set; }
        public Guid Key { get; set; }
    }
}
