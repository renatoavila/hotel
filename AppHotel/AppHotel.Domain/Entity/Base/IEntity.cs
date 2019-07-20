using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Domain.Entity
{
    public interface IEntity
    {
        int Id { get; set; }
        Guid Key { get; set; }
    }
}
