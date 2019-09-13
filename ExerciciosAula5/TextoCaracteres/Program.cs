using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextoCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Encontrados:{TextContent().Length}");
            Console.ReadKey();

        }

        private static string TextContent()
        {
            return (@"They say through time I'll find some healing but the clock goes slow
I didn't know that I could get this low");
        }
    }
}
