using System;
using System.Collections.Generic;
using System.Text;
using MongoDBRepository.Domain;
using MongoDBRepository.RepositoryLayer.Base;

namespace MongoDBRepository.RepositoryLayer
{
    public sealed class AlunoRepository : Repository<Aluno>
    {
        public AlunoRepository(
            string connectionString, string databaseName) 
            : base(connectionString, databaseName)
        {
            
        }
    }
}
