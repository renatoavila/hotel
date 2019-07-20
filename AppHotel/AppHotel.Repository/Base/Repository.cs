using AppHotel.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppHotel.Repository.Base
{
    public abstract class Repository<T> : IRepository<T> where T : IEntity
    {
        private List<T> _data;

        private static object _syncObj = new object();

        public Repository()
        {
            if (_data == null)
            {
                lock (_syncObj)
                {
                    if (_data == null)
                    {
                        _data = new List<T>();
                    }
                }
            }
        }

        public T Get(int id)
        {
            return _data.Find(x => x.Id == id);
        }

        public T Get(Guid key)
        {
            return _data.Find(x => x.Key == key);
        }

        public List<T> Get(int skip, int take)
        {
            return _data.Skip(skip).Take(take).ToList();
        }

        public List<T> Get()
        {
            return _data;
        }

        public void Create(T obj)
        {
            _data.Add(obj);
        }

        public void Update(T obj)
        {
            T old = Get(obj.Key);
            Delete(old);
            Create(obj);
        }

        public void Delete(T obj)
        {
            _data.Remove(obj);
        }
    }
}
