using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PublicMetod
{
    public class Program
    {
        static void Main(string[] args)

        {
            PublicMetod();
        }
        /// <summary>
        /// Meotodo principal de inicialização do sistema
        /// </summary>
        public static void PublicMetod()
        {
            Console.WriteLine("---Sistema conversor de moedas sucessãooo---");
            Console.WriteLine("Informe um valor a ser convertido:");

            var valorASerConvertido = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma moeda para conversão");
            Console.WriteLine("DOLAR,EURO,YEN,BTC");

            var moedaAlvoParaConverter = Console.ReadLine().ToUpper();

            Console.WriteLine($"Valor da moeda convertida em {moedaAlvoParaConverter} ");

            ConvertMoeda(valorASerConvertido, moedaAlvoParaConverter);

            Console.ReadKey();
        }
        /// <summary>
        /// metodo que converte real para um alvo especificado
        /// para converter digite os alvos:
        /// "EURO" 
        /// "YEN"
        /// "BTC"
        /// "DOLAR"
        /// </summary>
        /// <param name="minhaMoeda">Moeda em valor real</param>
        /// <param name="moedaAlvo">Alvo podera ser convertido</param>
        public static void ConvertMoeda(double minhaMoeda,string moedaAlvo)
        {

            switch (moedaAlvo)
            {
                case "DOLAR":
                    Console.WriteLine(FormataNumeroDecimalEmDolar(minhaMoeda));
                    break;
                case "EURO":
                    Console.WriteLine(ConversaoDeRealParaEuro(minhaMoeda));
                    break;
                case
                    "YEN":
                    Console.WriteLine(ConversaoDeRealParaYEN(minhaMoeda));
                    break;
                case
                    "BTC":
                    Console.WriteLine(ConversaoDeRealParaBitCoin(minhaMoeda));
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Metodo que converte meu numero em real para dolar
        /// </summary>
        /// <param name="meuNumero">Meu numero em reais</param>
        /// <returns>Retorna o valor formatado em dolar</returns>
        public static string FormataNumeroDecimalEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }

        /// <summary>
        /// Metodo que converte meu numero em real para euro
        /// </summary>
        /// <param name="meuNumero">Meu numero em reais</param>
        /// <returns>Retorna o valor formatado em euror</returns>
        public static string ConversaoDeRealParaEuro(double meuNumero)
        {

            return (meuNumero / 4.53).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
                .Replace("$", "Euro ");
        }

        /// <summary>
        /// Metodo que converte meu numero em real para iene
        /// </summary>
        /// <param name="meuNumero">Meu numero em reais</param>
        /// <returns>Retorna o valor formatado em iene</returns>
        public static string ConversaoDeRealParaYEN(double meuNumero)
        {
            return (meuNumero / 0.038).ToString("C3", CultureInfo.CreateSpecificCulture("ja-JP"));
        }

        /// <summary>
        /// Metodo que converte meu numero em real para bitcoin
        /// </summary>
        /// <param name="meuNumero">Meu numero em reais</param>
        /// <returns>Retorna o valor formatado em bitcoin</returns>
        public static string ConversaoDeRealParaBitCoin(double meuNumero)
        {

            return (meuNumero / 41997.32).ToString("C10", CultureInfo.CreateSpecificCulture("en-US"))
           .Replace("$", "BTC");


        }
    }
}
