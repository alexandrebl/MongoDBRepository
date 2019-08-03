using System.Collections.Generic;
using MongoDB.Driver;
using MontoDBRepository.RepositoryLayer.Context;
using MontoDBRepository.RepositoryLayer.Interfaces;

namespace MontoDBRepository.RepositoryLayer.Base
{
    public abstract class Repository<T> : IRepository<T>
    {
        private readonly ConnectionFactory _connectionFactory;
        private readonly string _databaseName;
        protected Repository(string connectionString, string databaseName) 
        {
            _connectionFactory = new ConnectionFactory(connectionString);
            _databaseName = databaseName;
        }
        public List<T> QueryAll()
        {
            var collection = _connectionFactory
                .GetDataBase(_databaseName)
                    .GetCollection<T>(nameof(T));

            var data = collection?.AsQueryable()?.ToList();

            return data;
        }

        public bool Insert(T obj)
        {
            var collection = _connectionFactory
                .GetDataBase(_databaseName)
                .GetCollection<T>(nameof(T));

            collection.InsertOne(obj);

            return true;
        }
    }
}
