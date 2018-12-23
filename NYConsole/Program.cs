using NY.DAL;
using NY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                DateOfBirth = DateTime.Now,
                Email = "test@test.fr",
                Name = "Bilel",
                LastName = "Ben Khalifa"

            };
            using (var db = new NYDBContext())
            {
                var p = db.Persons.ToList();

            }


            Console.ReadKey();
        }
    }
}