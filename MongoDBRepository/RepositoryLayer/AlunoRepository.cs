using System;
using System.Collections.Generic;
using System.Text;
using MontoDBRepository.Domain;
using MontoDBRepository.RepositoryLayer.Base;

namespace MontoDBRepository.RepositoryLayer
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
