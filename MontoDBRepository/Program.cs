using System;
using MongoDBRepository.Domain;
using MongoDBRepository.RepositoryLayer;

namespace MongoDBRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "mongodb://localhost:27017";

            var alunoRepository = new AlunoRepository(connectionString, "escola");

            alunoRepository.Insert(new Aluno {Matricula = "1212213", Nome ="AAAA"});

            var alunos = alunoRepository.QueryAll();

            foreach (var aluno in alunos)
            {
                Console.WriteLine($"{aluno.Nome}, matricula: {aluno.Matricula}");
            }
        }
    }
}
