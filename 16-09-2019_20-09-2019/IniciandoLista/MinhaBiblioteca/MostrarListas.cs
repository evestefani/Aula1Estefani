using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class MostrarListas
    {
        public static void MetodoListarCervejas()
        {
            Console.WriteLine("Cite o nome de algumas cervejas da AMBEV:");
            var minhalIsta = new List<string>() { "Patagônia", "Brahma", "Original", "Corona", "Budweiser" };

            foreach (var item in minhalIsta)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        public static void MetodoListarCarros()

        {
            Console.WriteLine("Cite o nome de algumas marcas de automovéis:");
            var minhalIsta = new List<string>() { "Renault", "FORD", "Fiat", "Volkswagen", "Chevrolet", "JAC", "Honda", "Hyundai", "Jeep" };

            foreach (var item in minhalIsta)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

    }
}
