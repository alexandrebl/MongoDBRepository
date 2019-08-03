using System.Collections.Generic;

namespace MongoDBRepository.RepositoryLayer.Interfaces
{
    public interface IRepository<T>
    {
        List<T> QueryAll();

        bool Insert(T obj);
    }
}
