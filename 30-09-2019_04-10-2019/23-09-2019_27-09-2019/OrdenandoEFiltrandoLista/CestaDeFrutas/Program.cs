using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        #region
        {
            var cestaDeFrutas = new List<Fruta>();

            #region Carregando a minha cesta
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 0,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212
            });

            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95
            });

            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Manga",
                Cor = "Amarelo",
                Peso = 325
            });
            #endregion

            #region Lista 1
            //Neste ponto ordenamos os valores de forma descrescente pelo nome
            cestaDeFrutas.OrderByDescending(x => x.Nome).ToList<Fruta>().ForEach(item => Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Peso: {item.Peso}"));

            Console.WriteLine("---------------------------------");

            //Neste ponto ordenamos os valores pelo ID de forma crescente
            cestaDeFrutas.OrderBy(x => x.Nome).ToList<Fruta>().ForEach(item => Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Peso: {item.Peso}"));
            #endregion

            #region Lista 2
            Console.WriteLine();
            Console.WriteLine("---------- Filtro Peso ----------");

            //Neste ponto filtramos os registros maiores de 100gr -- ordenado pelo nome
            var filtroCesta = cestaDeFrutas.Where(x => x.Peso > 100).OrderBy(x => x.Nome);

            filtroCesta.ToList<Fruta>().ForEach(item => Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Peso: {item.Peso}"));
            #endregion

            #region Lista 3
            //frutinha recebe cada fruta de nossa cesta
            (from frutinha in cestaDeFrutas // <- aqui temos a coleção de frutas
             where frutinha.Peso > 100 // <- aqui escolhemos somente as frutas com mais de 100gr
             select frutinha) // <- neste ponto eu junto as informações que filtrei e retorno
             .ToList<Fruta>()// <- convertemos para uma lista amiga novamente
             .ForEach(item => Console.WriteLine($"Fruta escolhida {item.Nome}")); // <-imprimos essas informações pelo console
            #endregion

            #region Lista 4

            Console.WriteLine();
            Console.WriteLine("---------- Filtro Cor ----------");

            //aqui criamos uma variável que receberá o valor buscao
            var mostrandoFind = cestaDeFrutas.
            //aqui é feito o filtro das informações por uma "ou" --> || <-- outra cor
            Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");

            Console.WriteLine($"Id: {mostrandoFind.Id} - Nome: {mostrandoFind.Nome}");

            //aqui criamos uma variável que recebrá a coleção que estamos buscando
            var mostrandoFindAll = cestaDeFrutas.
            //FindAll com esta condição trás frutas de cor amarela "ou" vermelha
            FindAll(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
            //imprimo com a função do ForEach do linq
            mostrandoFindAll.ForEach(item => Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome}"));

            //aqui ordenamos a lista pelo nome
            var listaOrdenada = mostrandoFindAll.OrderBy(x => x.Nome);

            //como agora ele não é mais um List<Fruta> usamos o foreach para apresentar os valores
            foreach (var item in listaOrdenada)
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome}");

            Console.WriteLine();
            Console.WriteLine("---------- Find com OrderBy ----------");

            var cestaDeFrutasFindOrder = cestaDeFrutas.
            //ordenei a minha lista
            OrderBy(x => x.Nome)
            //converti para a lista de frutas novamente
            .ToList<Fruta>().
            //busco minha informação
            Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");

            Console.WriteLine($"Id: {cestaDeFrutasFindOrder.Id} - Nome: {cestaDeFrutasFindOrder.Nome}");



            #endregion


            Console.ReadKey();
            #endregion
        }

    }

}
