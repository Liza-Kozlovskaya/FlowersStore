using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
      class Program
        {
            static void Main(string[] args)
            {
                //Массив (букет) цветов
                Flower[] flowers = new Flower[10]
                {
                new Rose(120,Freshness.HighestFreshness,20),
                new Lily(100,Freshness.MediumFreshness,25),
                new Iris(95,Freshness.SaleFreshness,30),
                new Rose(120,Freshness.LowFreshness,26),
                new Peony(75, Freshness.MediumFreshness, 33),
                new Rose(120,Freshness.BelowAverageFreshness,37),
                new Aster(68, Freshness.AboveAverageFreshness, 31),
                new Peony(75, Freshness.HighestFreshness, 29),
                new Lily(100,Freshness.BelowAverageFreshness,28),
                new Lily(100,Freshness.MediumFreshness,23),
                };

            Console.WriteLine("___________________________________________\n");
            Console.WriteLine("Неотсортированные цветы");
            Console.WriteLine("___________________________________________\n");
            foreach (Flower f in flowers)
                {
                    Console.WriteLine(f.ToString());
                }
                Array.Sort(flowers);

            Console.WriteLine("___________________________________________\n");
            Console.WriteLine("Отсортированные цветы по степени свежести");
            Console.WriteLine("___________________________________________\n");
            foreach (Flower f in flowers)
                {
                    Console.WriteLine(f.ToString());
                }

            Console.WriteLine("___________________________________________\n");
            Console.WriteLine("Цветы со стеблем больше 30 см.");
            Console.WriteLine("___________________________________________\n");
            foreach (Flower f in flowers.Where(n => n.StemLength >= 30))
                {
                    Console.WriteLine(f.ToString());
                }
                Console.ReadLine();
            }
        }
}