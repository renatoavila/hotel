

using System.Collections.Generic;

namespace AppHotel.Repository.Interface
{
    public interface IRepository<T>
    {
        void Insert(T t, List<T> l);
        List<T> Get(List<T> l);
    }
}
