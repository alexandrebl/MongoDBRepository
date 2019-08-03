using System;
using MongoDB.Driver;

namespace MontoDBRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient(
                "mongodb://localhost:27017"
            );
            var database = client.GetDatabase("developersdb00");

            var collection = database.GetCollection<Aluno>("escola");

            collection.InsertOne(new Aluno{ Matricula = "121", Nome = "sdssd" });

            Console.WriteLine("Hello World!");
        }
    }
}
