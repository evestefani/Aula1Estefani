using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRelatorioCarros.Model
{
    public class SistemaVendasContext
    {
        /// <summary>
        /// Nossa massa de dados interna
        /// </summary>
        private List<Venda> ListaDeVendas { get; set; }

        /// <summary>
        /// Construtor que prepara a nossa massa de dados
        /// </summary>
        public SistemaVendasContext()
        {
            //Criamos a nossa lista de vendas"em memória", caso contrário ela fica null
            ListaDeVendas = new List<Venda>();

            #region Relatório de vendas

            ListaDeVendas.Add(new Venda(){Id = 1, Carro ="Risus Company", Valor = 7200, Quantidade = 18, Data = DateTime.Parse("29/01/2019")});
            ListaDeVendas.Add(new Venda(){Id = 2, Carro ="Risus Associates", Valor = 9961, Quantidade = 4,  Data = DateTime.Parse("10/02/2019")});
            ListaDeVendas.Add(new Venda(){Id = 3, Carro ="Et Libero Proin Foundation", Valor = 8710, Quantidade = 17, Data = DateTime.Parse("24/01/2019")});
            ListaDeVendas.Add(new Venda(){Id = 4, Carro ="Cursus Et Ltd", Valor = 9010, Quantidade = 17, Data = DateTime.Parse("26/10/2019")});
            ListaDeVendas.Add(new Venda(){Id = 5, Carro ="Odio Etiam Ligula Company", Valor = 5245, Quantidade = 8,  Data = DateTime.Parse("16/02/2019")});
            ListaDeVendas.Add(new Venda(){Id = 6, Carro ="Eu Nibh Inc.", Valor = 7922, Quantidade = 9,  Data = DateTime.Parse("27/06/2019")});
            ListaDeVendas.Add(new Venda(){Id = 7, Carro ="Tellus Limited", Valor = 7294, Quantidade = 7,  Data = DateTime.Parse("26/01/2019")});
            ListaDeVendas.Add(new Venda(){Id = 8, Carro ="Imperdiet PC", Valor = 8305, Quantidade = 5,  Data = DateTime.Parse("06/09/2019")});
            ListaDeVendas.Add(new Venda(){Id = 9, Carro ="Elit Inc.", Valor = 5398, Quantidade = 18, Data = DateTime.Parse("09/06/2019")});
            ListaDeVendas.Add(new Venda(){Id = 10, Carro ="Quam A Limited", Valor = 5398, Quantidade = 14, Data = DateTime.Parse("09/09/2019")});
            ListaDeVendas.Add(new Venda(){Id = 11, Carro ="Adipiscing Institute", Valor = 8133, Quantidade = 4,  Data = DateTime.Parse("24/10/2019")});
            ListaDeVendas.Add(new Venda(){Id = 12, Carro ="Posuere At Velit Ltd", Valor = 5121, Quantidade = 15, Data = DateTime.Parse("19/11/2019")});
            ListaDeVendas.Add(new Venda(){Id = 13, Carro ="Nunc In Industries", Valor = 8902, Quantidade = 2,  Data = DateTime.Parse("21/07/2019")});
            ListaDeVendas.Add(new Venda(){Id = 14, Carro ="Integer Vitae Nibh Corporation", Valor = 6313, Quantidade = 20, Data = DateTime.Parse("02/02/2019")});
            ListaDeVendas.Add(new Venda(){Id = 15, Carro ="Tellus Nunc Lectus Company", Valor = 9650, Quantidade = 2,  Data = DateTime.Parse("20/07/2019")});
            ListaDeVendas.Add(new Venda(){Id = 16, Carro ="Suspendisse LLC", Valor = 5319, Quantidade = 12, Data = DateTime.Parse("24/12/2019")});
            ListaDeVendas.Add(new Venda(){Id = 17, Carro ="Mauris Vestibulum Corporation", Valor = 5790, Quantidade = 5,  Data = DateTime.Parse("14/11/2019")});
            ListaDeVendas.Add(new Venda(){Id = 18, Carro ="Sed Nec Corp.", Valor = 8421, Quantidade = 2,  Data = DateTime.Parse("05/05/2019")});
            ListaDeVendas.Add(new Venda(){Id = 19, Carro ="Enim Nisl Elementum Inc.", Valor = 5904, Quantidade = 6,  Data = DateTime.Parse("26/06/2019")});
            ListaDeVendas.Add(new Venda(){Id = 20, Carro ="Ac Mattis Semper Corporation", Valor = 5110, Quantidade = 4,  Data = DateTime.Parse("14/01/2019")});
            ListaDeVendas.Add(new Venda(){Id = 21, Carro ="Donec Tempus Lorem LLC", Valor = 8576, Quantidade = 16, Data = DateTime.Parse("29/03/2019")});
            ListaDeVendas.Add(new Venda(){Id = 22, Carro ="Tempor Augue Ac Ltd", Valor = 9072, Quantidade = 16, Data = DateTime.Parse("09/07/2019")});
            ListaDeVendas.Add(new Venda(){Id = 23, Carro ="Diam Duis Mi LLC", Valor = 8472, Quantidade = 4,  Data = DateTime.Parse("23/09/2019")});
            ListaDeVendas.Add(new Venda(){Id = 24, Carro ="Aliquam Corp.", Valor = 6607, Quantidade = 4,  Data = DateTime.Parse("28/09/2019")});
            ListaDeVendas.Add(new Venda(){Id = 25, Carro ="Montes Institute", Valor = 6176, Quantidade = 8,  Data = DateTime.Parse("19/06/2019")});
            ListaDeVendas.Add(new Venda(){Id = 26, Carro ="Hendrerit Institute", Valor = 8387, Quantidade = 11, Data = DateTime.Parse("17/09/2019")});
            ListaDeVendas.Add(new Venda(){Id = 27, Carro ="Erat Etiam Vestibulum Corporation", Valor = 7584, Quantidade = 9,  Data = DateTime.Parse("02/06/2019")});
            ListaDeVendas.Add(new Venda(){Id = 28, Carro ="Adipiscing Ltd", Valor = 7887, Quantidade = 9,  Data = DateTime.Parse("19/03/2019")});
            ListaDeVendas.Add(new Venda(){Id = 29, Carro ="In Tempus Eu Inc.", Valor = 5233, Quantidade = 16, Data = DateTime.Parse("20/07/2019")});
            ListaDeVendas.Add(new Venda(){Id = 30, Carro ="Elit Institute", Valor = 7359, Quantidade = 11, Data = DateTime.Parse("12/09/2019")});
            ListaDeVendas.Add(new Venda(){Id = 31, Carro ="Aliquam Erat LLC", Valor = 8842, Quantidade = 4,  Data = DateTime.Parse("14/03/2019")});
            ListaDeVendas.Add(new Venda(){Id = 32, Carro ="A Feugiat Tellus PC", Valor = 9176, Quantidade = 4,  Data = DateTime.Parse("10/12/2019")});
            ListaDeVendas.Add(new Venda(){Id = 33, Carro ="Aliquet Incorporated", Valor = 9057, Quantidade = 8,  Data = DateTime.Parse("26/04/2019")});
            ListaDeVendas.Add(new Venda(){Id = 34, Carro ="Dolor Dolor Tempus Institute", Valor = 8433, Quantidade = 15, Data = DateTime.Parse("31/10/2019")});
            ListaDeVendas.Add(new Venda(){Id = 35, Carro ="Risus Odio Auctor PC", Valor = 8286, Quantidade = 11, Data = DateTime.Parse("29/03/2019")});
            ListaDeVendas.Add(new Venda(){Id = 36, Carro ="Aliquet Molestie Tellus Corp.", Valor = 8779, Quantidade = 1,  Data = DateTime.Parse("05/07/2019")});
            ListaDeVendas.Add(new Venda(){Id = 37, Carro ="Ipsum Corp.", Valor = 5568, Quantidade = 15, Data = DateTime.Parse("10/03/2019")});
            ListaDeVendas.Add(new Venda(){Id = 38, Carro ="Mi Lacinia Foundation", Valor = 7442, Quantidade = 20, Data = DateTime.Parse("09/07/2019")});
            ListaDeVendas.Add(new Venda(){Id = 39, Carro ="Cubilia Curae; Corp.", Valor = 8421, Quantidade = 7,  Data = DateTime.Parse("26/05/2019")});
            ListaDeVendas.Add(new Venda(){Id = 40, Carro ="Velit Sed Malesuada Associates", Valor = 9841, Quantidade = 6,  Data = DateTime.Parse("07/11/2019")});
            ListaDeVendas.Add(new Venda(){Id = 41, Carro ="Duis Foundation", Valor = 9849, Quantidade = 6,  Data = DateTime.Parse("08/12/2019")});
            ListaDeVendas.Add(new Venda(){Id = 42, Carro ="Erat Semper Consulting", Valor = 6168, Quantidade = 10, Data = DateTime.Parse("10/11/2019")});
            ListaDeVendas.Add(new Venda(){Id = 43, Carro ="Turpis Inc.", Valor = 7758, Quantidade = 7,  Data = DateTime.Parse("12/08/2019")});
            ListaDeVendas.Add(new Venda(){Id = 44, Carro ="Aenean Industries", Valor = 8770, Quantidade = 12, Data = DateTime.Parse("10/09/2019")});
            ListaDeVendas.Add(new Venda(){Id = 45, Carro ="Nulla Industries", Valor = 8884, Quantidade = 8,  Data = DateTime.Parse("10/11/2019")});
            ListaDeVendas.Add(new Venda(){Id = 46, Carro ="Semper Egestas Urna Inc.", Valor = 9428, Quantidade = 11, Data = DateTime.Parse("26/06/2019")});
            ListaDeVendas.Add(new Venda(){Id = 47, Carro ="Donec Luctus Aliquet Industries", Valor = 5928, Quantidade = 8,  Data = DateTime.Parse("11/07/2019")});
            ListaDeVendas.Add(new Venda(){Id = 48, Carro ="Cum Sociis Natoque Foundation", Valor = 7506, Quantidade = 2,  Data = DateTime.Parse("21/07/2019")});
            ListaDeVendas.Add(new Venda(){Id = 49, Carro ="Vitae Sodales Limited", Valor = 8912, Quantidade = 8,  Data = DateTime.Parse("22/06/2019")});
            ListaDeVendas.Add(new Venda(){Id = 50, Carro ="Tellus Sem Mollis Ltd", Valor = 9615, Quantidade = 20, Data = DateTime.Parse("30/10/2019")});
            ListaDeVendas.Add(new Venda(){Id = 51, Carro ="Nulla Tincidunt LLC", Valor = 5562, Quantidade = 19, Data = DateTime.Parse("22/09/2019")});
            ListaDeVendas.Add(new Venda(){Id = 52, Carro ="Sed Dictum Institute", Valor = 9243, Quantidade = 14, Data = DateTime.Parse("26/06/2019")});
            ListaDeVendas.Add(new Venda(){Id = 53, Carro ="Sed Turpis Company", Valor = 7243, Quantidade = 14, Data = DateTime.Parse("20/08/2019")});
            ListaDeVendas.Add(new Venda(){Id = 54, Carro ="Vitae Diam Proin Associates", Valor = 6631, Quantidade = 2,  Data = DateTime.Parse("10/06/2019")});
            ListaDeVendas.Add(new Venda(){Id = 55, Carro ="Curabitur Inc.", Valor = 8090, Quantidade = 3,  Data = DateTime.Parse("09/02/2019")});
            ListaDeVendas.Add(new Venda(){Id = 56, Carro ="Suscipit Est Ac LLC", Valor = 8567, Quantidade = 15, Data = DateTime.Parse("08/03/2019")});
            ListaDeVendas.Add(new Venda(){Id = 57, Carro ="Neque Morbi Industries", Valor = 5171, Quantidade = 1,  Data = DateTime.Parse("03/10/2019")});
            ListaDeVendas.Add(new Venda(){Id = 58, Carro ="Non Ltd", Valor = 5102, Quantidade = 19, Data = DateTime.Parse("14/08/2019")});
            ListaDeVendas.Add(new Venda(){Id = 59, Carro ="Arcu Vestibulum Ante Institute", Valor = 6128, Quantidade = 1,  Data = DateTime.Parse("08/10/2019")});
            ListaDeVendas.Add(new Venda(){Id = 60, Carro ="Nulla Foundation", Valor = 7636, Quantidade = 6,  Data = DateTime.Parse("14/04/2019")});
            ListaDeVendas.Add(new Venda(){Id = 61, Carro ="Quis Massa Mauris LLP", Valor = 5053, Quantidade = 3,  Data = DateTime.Parse("09/10/2019")});
            ListaDeVendas.Add(new Venda(){Id = 62, Carro ="Ut Incorporated", Valor = 6922, Quantidade = 17, Data = DateTime.Parse("16/09/2019")});
            ListaDeVendas.Add(new Venda(){Id = 63, Carro ="Aenean Egestas Corp.", Valor = 8142, Quantidade = 19, Data = DateTime.Parse("17/11/2019")});
            ListaDeVendas.Add(new Venda(){Id = 64, Carro ="Fusce Mi Lorem Consulting", Valor = 8312, Quantidade = 20, Data = DateTime.Parse("19/11/2019")});
            ListaDeVendas.Add(new Venda(){Id = 65, Carro ="A Sollicitudin Orci PC", Valor = 5864, Quantidade = 1,  Data = DateTime.Parse("20/03/2019")});
            ListaDeVendas.Add(new Venda(){Id = 66, Carro ="Sociosqu Limited", Valor = 5985, Quantidade = 12, Data = DateTime.Parse("28/11/2019")});
            ListaDeVendas.Add(new Venda(){Id = 67, Carro ="Ullamcorper Duis Cursus LLC", Valor = 5164, Quantidade = 7,  Data = DateTime.Parse("22/12/2019")});
            ListaDeVendas.Add(new Venda(){Id = 68, Carro ="Nibh Lacinia LLC", Valor = 7760, Quantidade = 10, Data = DateTime.Parse("13/06/2019")});
            ListaDeVendas.Add(new Venda(){Id = 69, Carro ="Eu Dui Institute", Valor = 7695, Quantidade = 8,  Data = DateTime.Parse("12/12/2019")});
            ListaDeVendas.Add(new Venda(){Id = 70, Carro ="Fringilla Purus Mauris Consulting", Valor = 5845, Quantidade = 6,  Data = DateTime.Parse("01/03/2019")});
            ListaDeVendas.Add(new Venda(){Id = 71, Carro ="Donec Tempus Lorem Industries", Valor = 8472, Quantidade = 19, Data = DateTime.Parse("09/03/2019")});
            ListaDeVendas.Add(new Venda(){Id = 72, Carro ="Auctor Incorporated", Valor = 6795, Quantidade = 1,  Data = DateTime.Parse("04/10/2019")});
            ListaDeVendas.Add(new Venda(){Id = 73, Carro ="Enim Etiam Imperdiet Corporation", Valor = 6532, Quantidade = 13, Data = DateTime.Parse("14/10/2019")});
            ListaDeVendas.Add(new Venda(){Id = 74, Carro ="Non Cursus Non Industries", Valor = 9569, Quantidade = 16, Data = DateTime.Parse("25/10/2019")});
            ListaDeVendas.Add(new Venda(){Id = 75, Carro ="Ut Semper Incorporated", Valor = 5760, Quantidade = 18, Data = DateTime.Parse("14/01/2019")});
            ListaDeVendas.Add(new Venda(){Id = 76, Carro ="Sed Malesuada Corporation", Valor = 6561, Quantidade = 4,  Data = DateTime.Parse("06/03/2019")});
            ListaDeVendas.Add(new Venda(){Id = 77, Carro ="Sed Neque Consulting", Valor = 7308, Quantidade = 2,  Data = DateTime.Parse("31/08/2019")});
            ListaDeVendas.Add(new Venda(){Id = 78, Carro ="Nisl Arcu PC", Valor = 7260, Quantidade = 8,  Data = DateTime.Parse("19/06/2019")});
            ListaDeVendas.Add(new Venda(){Id = 79, Carro ="Euismod Est Consulting", Valor = 6020, Quantidade = 11, Data = DateTime.Parse("27/10/2019")});
            ListaDeVendas.Add(new Venda(){Id = 80, Carro ="Leo Vivamus Ltd", Valor = 5055, Quantidade = 8,  Data = DateTime.Parse("22/10/2019")});
            ListaDeVendas.Add(new Venda(){Id = 81, Carro ="Tristique Neque Inc.", Valor = 9268, Quantidade = 13, Data = DateTime.Parse("25/02/2019")});
            ListaDeVendas.Add(new Venda(){Id = 82, Carro ="In Lobortis PC", Valor = 5539, Quantidade = 4,  Data = DateTime.Parse("18/12/2019")});
            ListaDeVendas.Add(new Venda(){Id = 83, Carro ="Nunc Ltd", Valor = 6846, Quantidade = 2,  Data = DateTime.Parse("09/10/2019")});
            ListaDeVendas.Add(new Venda(){Id = 84, Carro ="Dictum Proin Limited", Valor = 5543, Quantidade = 12, Data = DateTime.Parse("05/10/2019")});
            ListaDeVendas.Add(new Venda(){Id = 85, Carro ="Erat Vitae LLP", Valor = 5060, Quantidade = 7,  Data = DateTime.Parse("12/12/2019")});
            ListaDeVendas.Add(new Venda(){Id = 86, Carro ="Pellentesque Ultricies Dignissim PC", Valor = 7971, Quantidade = 15, Data = DateTime.Parse("25/10/2019")});
            ListaDeVendas.Add(new Venda(){Id = 87, Carro ="Phasellus Elit Company", Valor = 5350, Quantidade = 15, Data = DateTime.Parse("31/10/2019")});
            ListaDeVendas.Add(new Venda(){Id = 88, Carro ="Luctus Felis Ltd", Valor = 9872, Quantidade = 13, Data = DateTime.Parse("06/01/2019")});
            ListaDeVendas.Add(new Venda(){Id = 89, Carro ="Dui Suspendisse PC", Valor = 6878, Quantidade = 7,  Data = DateTime.Parse("06/02/2019")});
            ListaDeVendas.Add(new Venda(){Id = 90, Carro ="Odio Associates", Valor = 7636, Quantidade = 18, Data = DateTime.Parse("24/07/2019")});
            ListaDeVendas.Add(new Venda(){Id = 91, Carro ="Vel Company", Valor = 7410, Quantidade = 5,  Data = DateTime.Parse("16/02/2019")});
            ListaDeVendas.Add(new Venda(){Id = 92, Carro ="Lobortis Institute", Valor = 5110, Quantidade = 8,  Data = DateTime.Parse("27/05/2019")});
            ListaDeVendas.Add(new Venda(){Id = 93, Carro ="Scelerisque Company", Valor = 7983, Quantidade = 19, Data = DateTime.Parse("03/12/2019")});
            ListaDeVendas.Add(new Venda(){Id = 94, Carro ="Posuere Enim Company", Valor = 6968, Quantidade = 19, Data = DateTime.Parse("22/04/2019")});
            ListaDeVendas.Add(new Venda(){Id = 95, Carro ="Sem Ut Corp.", Valor = 6504, Quantidade = 11, Data = DateTime.Parse("02/02/2019")});
            ListaDeVendas.Add(new Venda(){Id = 96, Carro ="Dui Fusce Aliquam PC", Valor = 7837, Quantidade = 2,  Data = DateTime.Parse("08/12/2019")});
            ListaDeVendas.Add(new Venda(){Id = 97, Carro ="Nisl Sem Industries", Valor = 6835, Quantidade = 5,  Data = DateTime.Parse("14/11/2019")});
            ListaDeVendas.Add(new Venda(){Id = 98, Carro ="Vitae Corp.", Valor = 7669, Quantidade = 7,  Data = DateTime.Parse("09/11/2019")});
            ListaDeVendas.Add(new Venda(){Id = 99, Carro ="Malesuada Incorporated", Valor = 5960, Quantidade = 4,  Data = DateTime.Parse("26/09/2019")});
            ListaDeVendas.Add(new Venda(){Id = 100, Carro ="Mauris Ltd", Valor = 8974, Quantidade = 18, Data = DateTime.Parse("16/05/2019")});

            #endregion
        }

        /// <summary>
        /// Propriedade que contem as vendas realizadas sem nenhum tipo de filtro
        /// </summary>
        public List<Venda> ListaVendasPublica { get { return ListaDeVendas; } }

    }
}

