using System.Collections.Generic;

namespace MontoDBRepository.RepositoryLayer.Interfaces
{
    public interface IRepository<T>
    {
        List<T> QueryAll();

        bool Insert(T obj);
    }
}
