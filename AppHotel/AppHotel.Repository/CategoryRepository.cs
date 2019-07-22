using AppHotel.Domain.Entity;
using AppHotel.Repository.Base;
using AppHotel.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public Category Get(string value)
        {
            return Get().Find(x => x.Name == value);
        }
    }
}
