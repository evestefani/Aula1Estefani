using System;
using System.Globalization;
using System.Collections.Generic;


namespace ExerciciosAula1709
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodoArvore();
            MetodoCalculoAreaQuadrado();
            MetodoListarCervejas();
            MetodoListarCarros();
          


        }
        /// <summary>
        /// Metodo para desenhar uma arvore
        /// </summary>
        public static void MetodoArvore()

        {
            Console.WriteLine("                 *                    ");
            Console.WriteLine("               <xxx>                  ");
            Console.WriteLine("              <xxxxx>                 ");
            Console.WriteLine("             <xxxxxxx>                ");
            Console.WriteLine("            <xxxOxxxxxx>              ");
            Console.WriteLine("          <xxxxxxxxxxOxxx>            ");
            Console.WriteLine("         <xxxxxxOxxxxxxxxx>           ");
            Console.WriteLine("       <xxxxxxxxxxxxxxxxOxxx>         ");
            Console.WriteLine("      <xxxxxOxxxxxxxxxxxxxxxxx>       ");
            Console.WriteLine("    <xxxxxxxxxxxxxxxxxxOxxxxxxxx>     ");
            Console.WriteLine("  <xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx>   ");
            Console.WriteLine("             T TTTTTT                 ");
            Console.WriteLine("             T TTTTTT  T              ");
            Console.WriteLine("              TTTTTTT T               ");
            Console.WriteLine("               TTTTTTT                ");
            Console.WriteLine("               TTTTTT                 ");
            Console.WriteLine("uuuuuMMMuuuuuuuTTTTTTuuuuuuuuMMMuuuuuu");

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo para calcular a area de um quadrado
        /// </summary>
        public static void MetodoCalculoAreaQuadrado()
        {
            Console.WriteLine("Calcule a área do quadrado a seguir");
            Console.Write("Digite o valor da base (cm): ");
            var b = Convert.ToDouble(Console.ReadLine());

            b = b * b;

            Console.WriteLine(b.ToString("F5", CultureInfo.InvariantCulture) + " cm");

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo para listar cervejas
        /// </summary>
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
        /// <summary>
        /// Metodo para listar carros 
        /// </summary>
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

