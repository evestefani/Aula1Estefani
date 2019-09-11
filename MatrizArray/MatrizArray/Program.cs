using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayLinear = new string[3];

            arrayLinear[0] = "Felipe";
            arrayLinear[1] = "Estefani";
            arrayLinear[2] = "Diomar";

            List<string> listaLinear = new List<string>
            {
                "Felipe",
                "Estefani",
                "Euricledson"
            };

            Console.WriteLine(arrayLinear[0]);
            Console.WriteLine(listaLinear[0]);
            Console.ReadKey();
            var keypress = Console.ReadKey().KeyChar.ToString();
}
    }
}
