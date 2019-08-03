using System.Collections.Generic;

namespace MontoDBRepository.RepositoryLayer
{
    public interface IRepository<T>
    {
        List<T> QueryAll();

        bool Insert(T obj);
    }
}
