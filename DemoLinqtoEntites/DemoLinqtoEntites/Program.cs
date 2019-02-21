using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLinqtoEntites.Models.Content;
using System.Data.Entity;

namespace DemoLinqtoEntites
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TransportContext db = new TransportContext())
            {
                //Ленивая загрузка
                /*db.Configuration.LazyLoadingEnabled = true;
                var exporters = db.Exporters.AsQueryable();
                foreach(var item in exporters)
                {
                    Console.WriteLine(item.Name);

                    foreach (var weapon in item.Weapons)
                    {
                        Console.WriteLine($"{ weapon.Name} - { weapon.Price:N2}");
                    }
                }*/

                //Явная загрузка
                /*db.Configuration.LazyLoadingEnabled = false;
                var exporters = db.Exporters.Include("Weapons");
                Console.WriteLine(exporters);
                foreach (var item in exporters) //get exporters
                {
                    Console.WriteLine(item.Name);

                    foreach (var weapon in item.Weapons)
                    {
                        Console.WriteLine($"{ weapon.Name} - { weapon.Price:N2}");
                    }
                }*/

                /*db.Configuration.LazyLoadingEnabled = false;
                db.Weapons.Load();
                var exporters = db.Exporters.AsQueryable();
                Console.WriteLine(exporters);
                foreach (var item in exporters) //get exporters
                {
                    Console.WriteLine(item.Name);

                    foreach (var weapon in item.Weapons)
                    {
                        Console.WriteLine($"{ weapon.Name} - { weapon.Price:N2}");
                    }
                }*/


                db.Configuration.LazyLoadingEnabled = false;
                var routes = db.Routes.Include("Transports");
                
                foreach (var item in routes) 
                {
                    Console.WriteLine($"{item.Name} - {item.Number} ");

                    foreach (var transport in item.Transports)
                    {
                        Console.WriteLine($"{ transport.Name}");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
