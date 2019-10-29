using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeDecimais();
            FormataNumeroDecimalEmDolar(1000);
            ConversaoDeRealParaEuro(1000);
            ConversaoDeRealParaIene(1000);
            ConversaoDeRealParaBitCoin(1000);


            Console.ReadKey();
        }
        /// <summary>
        /// Mostra lista de datas definidas
        /// </summary>
        private static void ListaDateTime()

        {
            var minhaLista = new List<DateTime>();

            minhaLista.Add(new DateTime(2019, 09, 17));
            minhaLista.Add(new DateTime(2019, 09, 18));
            minhaLista.Add(new DateTime(2019, 09, 19));
            minhaLista.Add(new DateTime(2019, 09, 20));

            minhaLista.ForEach(minhadata => Console.WriteLine(minhadata.ToString("yyy/MMM/dd")));


        }
        /// <summary>
        /// Mostra lista de Strings (conjunto de caracteres) definidas
        /// </summary>
        private static void ListaString()

        {
            var minhalIsta = new List<string>();

            minhalIsta.Add("XIAMI");
            minhalIsta.Add("IPHONE APPLE");
            minhalIsta.Add("SAMSUNG");
            minhalIsta.Add("NOKIA");

            minhalIsta.ForEach(item => Console.WriteLine(item)); //=> passagem de referencia, passando para aquela direção cada item usado da lista

        }
        /// <summary>
        /// Mostra lista de numeros inteiros por int
        /// </summary>
        private static void ListaNumerosInteiros()

        {
            var minhalIsta = new List<int>();

            minhalIsta.Add(17);
            minhalIsta.Add(18);
            minhalIsta.Add(19);
            minhalIsta.Add(20);

            minhalIsta.ForEach(item => Console.WriteLine(item)); //=> passagem de referencia, passando para aquela direção cada item usado da lista


        }

        /// <summary>
        /// Mostra lista de numeros decimais com o double
        /// </summary>
        private static void ListaDeDecimais()

        {
            var minhasLista = new List<double>();

            minhasLista.Add(3.75);
            minhasLista.Add(34.98);
            minhasLista.Add(2.42);
            minhasLista.Add(0.02);

            minhasLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C") + "  " + FormataNumeroDecimalEmDolar(meuDecimal)
                + "  " + ConversaoDeRealParaEuro(meuDecimal) + "  " + ConversaoDeRealParaIene(meuDecimal) + "  " + ConversaoDeRealParaBitCoin(meuDecimal)));

        }
        /// <summary>
        /// Metodo que converte meu numero em real para dolar
        /// </summary>
        /// <param name="meuNumero">Meu numero em reais</param>
        /// <returns>Retorna o valor formatado em dolar</returns>
        private static string FormataNumeroDecimalEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }

        /// <summary>
        /// Metodo que converte meu numero em real para euro
        /// </summary>
        /// <param name="meuNumero">Meu numero em reais</param>
        /// <returns>Retorna o valor formatado em euror</returns>
        private static string ConversaoDeRealParaEuro(double meuNumero)
        {

            return (meuNumero / 4.53).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                .Replace("$", "Euro");
        }

        /// <summary>
        /// Metodo que converte meu numero em real para iene
        /// </summary>
        /// <param name="meuNumero">Meu numero em reais</param>
        /// <returns>Retorna o valor formatado em iene</returns>
        private static string ConversaoDeRealParaIene(double meuNumero)
        {
            return (meuNumero / 0.038).ToString("C3", CultureInfo.CreateSpecificCulture("ja-JP"));
        }

        /// <summary>
        /// Metodo que converte meu numero em real para bitcoin
        /// </summary>
        /// <param name="meuNumero">Meu numero em reais</param>
        /// <returns>Retorna o valor formatado em bitcoin</returns>
        private static string ConversaoDeRealParaBitCoin(double meuNumero)
        {

            return (meuNumero / 41997.32).ToString("C10", CultureInfo.CreateSpecificCulture("en-US"))
           .Replace("$", "BTC");


        }
    } 
}
