using AppHotel.Domain.Entity;
using AppHotel.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Repository
{
    public class RoomRepository : Repository<Room>
    {
        public Room Get(string number)
        {
            return Get().Find(x => x.Number == number);
        }

        public Room Get(Category category, string number)
        {
            return Get().Find(x => x.Category == category && x.Number == number);
        }

        public List<Room> Get(Category category)
        {
            return Get().FindAll(x => x.Category == category);
        }

    }
}
