using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Venda> vendas = new List<Venda>()
            {
                new Venda()
                {
                    Produto = "Iphone X 64Gb Branco 24mpx",
                    Quantidade = 7,
                    Valor = 4999.99
                },
                new Venda()
                {
                    Produto = "SLIM 3500 APP",
                    Quantidade = 3,
                    Valor = 2880.96
                },
                new Venda()
                {
                    Produto = "Motorola",
                    Quantidade = 5,
                    Valor = 2100.99
                }
            };

            Console.WriteLine("Média de produtos vendidos neste mês: ");
            Console.WriteLine(vendas.Average(x => x.Quantidade));
            //Average tira a média dos números inteiros, divide o valor total pela quantidade de itens em nossa lista
            Console.WriteLine("Média de vendas deste mês em R$: ");
            Console.WriteLine(vendas.
            //Aqui realizamos o cálculo de quantidade * valor = total de venda do produto
            Average(x => x.Quantidade * x.Valor));

            Console.ReadKey();
        }

    }
}
