using System;
using System.Globalization;
using System.Collections.Generic;
namespace FirstProject
{
    internal class Program
    {
        public class Person()
        {
            public byte Age { get; set; }
            public int Code { get; set; }
            public char Gender { get; set; }
            public decimal Height { get; set; }
        }

        public class Products()
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        static void Main(string[] args)
        {
            List<Products> products = new() { new() { Name = "L Desk", Price = 500.2367M }, new() { Name = "Computer", Price = 2100.2134M } };
            List<Person> persons = new() { new() { Age = 30, Code = 5290, Gender = 'M', Height = 53.234567M }, new() { Age = 35, Code = 2163, Gender = 'F', Height = 53.679845M } };

            Console.WriteLine($"Produtos: ");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}, cujo preço é {product.Price:F2}");
                Console.WriteLine($"------------------");

            }

            Console.WriteLine($"Registros: ");
            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Age} anos de idade, código {person.Code} e genero {person.Gender}");
                Console.WriteLine($"Medida com seis casas decimais {person.Height} \nArredondado (três casas decimais): {person.Height:F3}");
                Console.WriteLine($"Separador decimal invariant culture {person.Height.ToString("F3", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"------------------");

            }
        }
    }
}