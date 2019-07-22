using AppHotel.Domain.Entity;
using AppHotel.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Repository.Interface
{
    public interface IRoomRepository : IRepository<Room>
    {
        Room Get(string number);

        Room Get(Category category, string number);

        List<Room> Get(Category category);
    }

}
