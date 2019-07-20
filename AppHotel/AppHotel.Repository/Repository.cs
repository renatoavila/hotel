using System;
using System.Collections.Generic;
using AppHotel.Repository.Interface;

namespace AppHotel.Repository
{
    public class Repository<T> : IRepository<T>
    {
       
        public List<T> Get(List<T> list)
        {
            return list;
        }

        public void Insert(T t, List<T> list)
        {
            list.Add(t);
        }
    }
}
