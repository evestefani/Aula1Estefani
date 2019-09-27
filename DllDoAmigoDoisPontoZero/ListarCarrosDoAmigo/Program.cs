using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Controller;

namespace ListarCarrosDoAmigo
{
    class Program
    {
        static CarroController controller = new CarroController();
        static void Main(string[] args)
        {
            controller.GetCarros().ForEach(i => Console.WriteLine($"Id: {i.Id} - Marca: {i.Marca} - Modelo: {i.Modelo} - CC: {i.Cilindradas} - Portas: {i.Portas}"));

            Console.ReadLine();

        }
    }
}
