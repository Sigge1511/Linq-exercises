using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace v8tis
{
    internal class Help
    {
        public List<Person> persons = new List<Person>();
        public List<Product> products = new List<Product>();
        public List<Student> students = new List<Student>();

        //Övning 1
        //public void Run() 
        //{ 
        //    CreatePerson();
        //    foreach (Person p in persons) 
        //    {
        //        Console.WriteLine($"{p.Firstname} {p.Lastname}, {p.Age} år.");
        //    }
        //    Console.WriteLine("\n\n");
        //    var persons2 = persons.OrderBy(p=>p.Lastname);
        //    foreach (Person p in persons2)
        //    {
        //        Console.WriteLine($"{p.Firstname} {p.Lastname}, {p.Age} år.");
        //    }
        //    Console.WriteLine("\n\n");
        //    var persons3 = persons.OrderBy(p => p.Firstname);
        //    foreach (Person p in persons3)
        //    {
        //        Console.WriteLine($"{p.Firstname} {p.Lastname}, {p.Age} år.");
        //    }
        //}

        //*****************************************************************************************************************************************

        //Övning 2
        //public void Run()
        //{
        //    CreateProduct();
        //    var products2 = products.GroupBy(p => p.Category);
        //    foreach (var c in products2) 
        //    {
        //        Console.WriteLine($"{c.Key}: {c.Count()} föremål");
        //        foreach (var p in c) 
        //        {
        //            Console.WriteLine(p.Name);
        //        }
        //        Console.WriteLine();
        //    }
        //}
        //*****************************************************************************************************************************************

        //Övning 3
        //public void Run()
        //{
        //    CreateStudent();
        //    var groups = students.GroupBy(s => s.ClassYear)
        //        .OrderBy(g => g.Key)
        //.Select(g => g.OrderBy(g => g.Age)
        //        .ThenBy(g => g.Firstname));

        //    foreach (var group in groups)
        //    {
        //        Console.WriteLine($"Klass {group.First().ClassYear}:");

        //        foreach (var student in group)
        //        {
        //            Console.WriteLine($"  Namn: {student.Firstname} {student.Lastname}, {student.Age} år.");
        //        }
        //        Console.WriteLine();
        //    }
        //}  
        //*****************************************************************************************************************************************

        //Övning 4
        //public void Run()
        //  {
        //      string loadedpersons = File.ReadAllText("People.json");
        //      List<Person> jsonpersons = new List<Person>(JsonSerializer.Deserialize<List<Person>>(loadedpersons) ?? new List<Person>());


        //      foreach (Person p in jsonpersons)
        //      {
        //          Console.WriteLine($"{p.Firstname} {p.Lastname}, {p.Age} år.");
        //      }
        //      Console.WriteLine("\n\n");
        //      var persons2 = jsonpersons.OrderBy(p => p.Lastname);
        //      foreach (Person person in persons2)
        //      {
        //          Console.WriteLine($"{person.Firstname} {person.Lastname}, {person.Age} år.");
        //      }
        //      Console.WriteLine("\n\n");
        //      var persons3 = jsonpersons.OrderBy(p => p.Firstname);
        //      foreach (Person person in persons3)
        //      {
        //          Console.WriteLine($"{person.Firstname} {person.Lastname}, {person.Age} år.");
        //      }
        //  }
        //*****************************************************************************************************************************************

        //Övning 5
        //public void Run()
        //    {
        //        string loadedproducts = File.ReadAllText("products.json");
        //        List<Product> jsonproducts = new List<Product>(JsonSerializer.Deserialize<List<Product>>(loadedproducts) ?? new List<Product>());
        //        var jsonproducts2 = jsonproducts.GroupBy(p => p.Category);
        //        foreach (var c in jsonproducts2)
        //        {
        //            Console.WriteLine($"{c.Key}: {c.Count()} föremål");
        //            foreach (var p in c)
        //            {
        //                Console.WriteLine(p.Name);
        //            }
        //            Console.WriteLine();

        //        }
        //    }
        //*****************************************************************************************************************************************
        public void CreateStudent() 
        {
            students.Add(new Student("Maja", "Sigge", 33, "net25"));
            students.Add(new Student("Nellie", "Andersson", 23, "net23"));
            students.Add(new Student("Amanda", "Vikberg", 34, "net22"));
            students.Add(new Student("Sally", "Sigfeldt", 7, "net24"));
            students.Add(new Student("Kent", "Kula", 55, "net25"));
            students.Add(new Student("Agneta", "Fläktrökare", 49, "net24"));
            students.Add(new Student("Morran", "Gullis", 57, "net23"));
            students.Add(new Student("Tobias", "Bubbis", 28, "net25"));
        }
        public void CreateProduct() 
        {
            products.Add(new Product("Ost", "Mat"));
            products.Add(new Product("Pasta", "Mat"));
            products.Add(new Product("Pesto", "Mat"));
            products.Add(new Product("Torrschampo", "Hygien"));
            products.Add(new Product("Snus", "Tobak"));
            products.Add(new Product("Alvedon", "Medicin"));
            products.Add(new Product("Prosecco", "Dryck"));
            products.Add(new Product("Deodorant", "Hygien"));
            products.Add(new Product("Blend cigaretter", "Tobak"));
            products.Add(new Product("Sauvignon blanc", "Dryck"));
            products.Add(new Product("Parfym", "Hygien"));
            products.Add(new Product("Postafen", "Medicin"));
            products.Add(new Product("Bröd", "Mat"));
        }
        public void CreatePerson() 
        { 
            persons.Add(new Person("Maja", "Sigge", 33));
            persons.Add(new Person("Nellie", "Andersson", 23));
            persons.Add(new Person("Amanda", "Vikberg", 34));
            persons.Add(new Person("Sally", "Sigfeldt", 7));
            persons.Add(new Person("Kent", "Kula", 55));
            persons.Add(new Person("Agneta", "Fläktrökare", 49));
            persons.Add(new Person("Morran", "Gullis", 57));
            persons.Add(new Person("Tobias", "Bubbis", 28));            
        }
    }
}
