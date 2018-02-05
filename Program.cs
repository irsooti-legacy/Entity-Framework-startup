using System;
using System.Linq;
using EfScaffoldingProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfScaffoldingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SchoolContext();

            context.Database.EnsureCreated();
            context.Database.Migrate();

            var count = context.Courses.Count();

            Console.WriteLine($"{count} elements.");
        }
    }
}
