using System.Collections.Generic;

namespace ConsoleApp2.RepositoryLayer
{
    public interface IRepository<T>
    {
        List<T> QueryAll();

        bool Insert(T obj);
    }
}
