using System;
using System.Linq;
using EfScaffoldingProject.Entites;

namespace EfScaffoldingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new sakilaContext();

            Console.WriteLine($"{context.Actors.Count()} actors in database.");
        }
    }
}
