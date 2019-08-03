using System;
using MongoDB.Driver;
using MontoDBRepository.RepositoryLayer;

namespace MontoDBRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunoRepository =
                new AlunoRepository(
                    "mongodb://localhost:27017", "escola");

            alunoRepository.Insert(new Aluno()
                {Matricula = "123", Nome = "ABC"});

            var alunos = alunoRepository.QueryAll();

            foreach (var aluno in alunos)
            {
                Console.WriteLine($"{aluno.Matricula} - {aluno.Nome}");
            }
        }
    }
}
