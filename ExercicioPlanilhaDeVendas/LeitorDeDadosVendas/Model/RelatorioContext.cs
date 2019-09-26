using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitorDeDadosVendas.Model
{
    public class RelatorioContext
    {
        public List<ListaDeVendas> ListaDeVendas { get; set; }

        public RelatorioContext()
        #region Relatório de vendas
        {

            ListaDeVendas = new List<ListaDeVendas>();

            ListaDeVendas.Add(new ListaDeVendas() { ID = 1, Carro = "Risus Company                       ", Valor = 7.200, Quantidade = 18, Data = DateTime.Parse(" 29 / 01 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 2, Carro = "Risus Associates                    ", Valor = 9.961, Quantidade = 4, Data = DateTime.Parse(" 10 / 02 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 3, Carro = "Et Libero Proin Foundation          ", Valor = 8.710, Quantidade = 17, Data = DateTime.Parse(" 24 / 01 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 4, Carro = "Cursus Et Ltd                       ", Valor = 9.010, Quantidade = 17, Data = DateTime.Parse(" 26 / 10 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 5, Carro = "Odio Etiam Ligula Company           ", Valor = 5.245, Quantidade = 8, Data = DateTime.Parse(" 16 / 02 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 6, Carro = "Eu Nibh Inc.                        ", Valor = 7.922, Quantidade = 9, Data = DateTime.Parse(" 27 / 06 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 7, Carro = "Tellus Limited                      ", Valor = 7.294, Quantidade = 7, Data = DateTime.Parse(" 26 / 01 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 8, Carro = "Imperdiet PC                        ", Valor = 8.305, Quantidade = 5, Data = DateTime.Parse(" 06 / 09 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 9, Carro = "Elit Inc.	                         ", Valor = 5.398, Quantidade = 18, Data = DateTime.Parse(" 09 / 06 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 10, Carro = "Quam A Limited                     ", Valor = 5.398, Quantidade = 14, Data = DateTime.Parse(" 09 / 09 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 11, Carro = "Adipiscing Institute               ", Valor = 8.133, Quantidade = 4, Data = DateTime.Parse(" 24 / 10 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 12, Carro = "Posuere At Velit Ltd               ", Valor = 5.121, Quantidade = 15, Data = DateTime.Parse(" 19 / 11 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 13, Carro = "Nunc In Industries                 ", Valor = 8.902, Quantidade = 2, Data = DateTime.Parse(" 21 / 07 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 14, Carro = "Integer Vitae Nibh Corporation     ", Valor = 6.313, Quantidade = 20, Data = DateTime.Parse(" 02 / 02 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 15, Carro = "Tellus Nunc Lectus Company         ", Valor = 9.650, Quantidade = 2, Data = DateTime.Parse(" 20 / 07 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 16, Carro = "Suspendisse LLC                    ", Valor = 5.319, Quantidade = 12, Data = DateTime.Parse(" 24 / 12 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 17, Carro = "Mauris Vestibulum Corporation      ", Valor = 5.790, Quantidade = 5, Data = DateTime.Parse(" 14 / 11 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 18, Carro = "Sed Nec Corp.                      ", Valor = 8.421, Quantidade = 2, Data = DateTime.Parse(" 05 / 05 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 19, Carro = "Enim Nisl Elementum Inc.	         ", Valor = 5.904, Quantidade = 6, Data = DateTime.Parse(" 26 / 06 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 20, Carro = "Ac Mattis Semper Corporation       ", Valor = 5.110, Quantidade = 4, Data = DateTime.Parse(" 14 / 01 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 21, Carro = "Donec Tempus Lorem LLC             ", Valor = 8.576, Quantidade = 16, Data = DateTime.Parse(" 29 / 03 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 22, Carro = "Tempor Augue Ac Ltd                ", Valor = 9.072, Quantidade = 16, Data = DateTime.Parse(" 09 / 07 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 23, Carro = "Diam Duis Mi LLC                   ", Valor = 8.472, Quantidade = 4, Data = DateTime.Parse(" 23 / 09 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 24, Carro = "Aliquam Corp.	                     ", Valor = 6.607, Quantidade = 4, Data = DateTime.Parse(" 28 / 09 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 25, Carro = "Montes Institute                   ", Valor = 6.176, Quantidade = 8, Data = DateTime.Parse(" 19 / 06 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 26, Carro = "Hendrerit Institute                ", Valor = 8.387, Quantidade = 11, Data = DateTime.Parse(" 17 / 09 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 27, Carro = "Erat Etiam Vestibulum Corporation  ", Valor = 7.584, Quantidade = 9, Data = DateTime.Parse(" 02 / 06 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 28, Carro = "Adipiscing Ltd                     ", Valor = 7.887, Quantidade = 9, Data = DateTime.Parse(" 19 / 03 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 29, Carro = "In Tempus Eu Inc.	                 ", Valor = 5.233, Quantidade = 16, Data = DateTime.Parse(" 20 / 07 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 30, Carro = "Elit Institute                     ", Valor = 7.359, Quantidade = 11, Data = DateTime.Parse(" 12 / 09 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 31, Carro = "Aliquam Erat LLC                   ", Valor = 8.842, Quantidade = 4, Data = DateTime.Parse(" 14 / 03 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 32, Carro = "A Feugiat Tellus PC                ", Valor = 9.176, Quantidade = 4, Data = DateTime.Parse(" 10 / 12 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 33, Carro = "Aliquet Incorporated               ", Valor = 9.057, Quantidade = 8, Data = DateTime.Parse(" 26 / 04 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 34, Carro = "Dolor Dolor Tempus Institute       ", Valor = 8.433, Quantidade = 15, Data = DateTime.Parse(" 31 / 10 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 35, Carro = "Risus Odio Auctor PC               ", Valor = 8.286, Quantidade = 11, Data = DateTime.Parse(" 29 / 03 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 36, Carro = "Aliquet Molestie Tellus Corp.	     ", Valor = 8.779, Quantidade = 1, Data = DateTime.Parse(" 05 / 07 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 37, Carro = "Ipsum Corp.	                     ", Valor = 5.568, Quantidade = 15, Data = DateTime.Parse(" 10 / 03 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 38, Carro = "Mi Lacinia Foundation              ", Valor = 7.442, Quantidade = 20, Data = DateTime.Parse(" 09 / 07 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 39, Carro = "Cubilia Curae; Corp.               ", Valor = 8.421, Quantidade = 7, Data = DateTime.Parse(" 26 / 05 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 40, Carro = "Velit Sed Malesuada Associates     ", Valor = 9.841, Quantidade = 6, Data = DateTime.Parse(" 07 / 11 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 41, Carro = "Duis Foundation                    ", Valor = 9.849, Quantidade = 6, Data = DateTime.Parse(" 08 / 12 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 42, Carro = "Erat Semper Consulting             ", Valor = 6.168, Quantidade = 10, Data = DateTime.Parse(" 10 / 11 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 43, Carro = "Turpis Inc.	                     ", Valor = 7.758, Quantidade = 7, Data = DateTime.Parse(" 12 / 08 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 44, Carro = "Aenean Industries                  ", Valor = 8.770, Quantidade = 12, Data = DateTime.Parse(" 10 / 09 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 45, Carro = "Nulla Industries                   ", Valor = 8.884, Quantidade = 8, Data = DateTime.Parse(" 10 / 11 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 46, Carro = "Semper Egestas Urna Inc.	         ", Valor = 9.428, Quantidade = 11, Data = DateTime.Parse(" 26 / 06 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 47, Carro = "Donec Luctus Aliquet Industries    ", Valor = 5.928, Quantidade = 8, Data = DateTime.Parse(" 11 / 07 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 48, Carro = "Cum Sociis Natoque Foundation      ", Valor = 7.506, Quantidade = 2, Data = DateTime.Parse(" 21 / 07 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 49, Carro = "Vitae Sodales Limited              ", Valor = 8.912, Quantidade = 8, Data = DateTime.Parse(" 22 / 06 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 50, Carro = "Tellus Sem Mollis Ltd              ", Valor = 9.615, Quantidade = 20, Data = DateTime.Parse(" 30 / 10 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 51, Carro = "Nulla Tincidunt LLC                ", Valor = 5.562, Quantidade = 19, Data = DateTime.Parse(" 22 / 09 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 52, Carro = "Sed Dictum Institute               ", Valor = 9.243, Quantidade = 14, Data = DateTime.Parse(" 26 / 06 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 53, Carro = "Sed Turpis Company                 ", Valor = 7.243, Quantidade = 14, Data = DateTime.Parse(" 20 / 08 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 54, Carro = "Vitae Diam Proin Associates        ", Valor = 6.631, Quantidade = 2, Data = DateTime.Parse(" 10 / 06 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 55, Carro = "Curabitur Inc.	                 ", Valor = 8.090, Quantidade = 3, Data = DateTime.Parse(" 09 / 02 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 56, Carro = "Suscipit Est Ac LLC                ", Valor = 8.567, Quantidade = 15, Data = DateTime.Parse(" 08 / 03 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 57, Carro = "Neque Morbi Industries             ", Valor = 5.171, Quantidade = 1, Data = DateTime.Parse(" 03 / 10 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 58, Carro = "Non Ltd                            ", Valor = 5.102, Quantidade = 19, Data = DateTime.Parse(" 14 / 08 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 59, Carro = "Arcu Vestibulum Ante Institute     ", Valor = 6.128, Quantidade = 1, Data = DateTime.Parse(" 08 / 10 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 60, Carro = "Nulla Foundation                   ", Valor = 7.636, Quantidade = 6, Data = DateTime.Parse(" 14 / 04 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 61, Carro = "Quis Massa Mauris LLP              ", Valor = 5.053, Quantidade = 3, Data = DateTime.Parse(" 09 / 10 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 62, Carro = "Ut Incorporated                    ", Valor = 6.922, Quantidade = 17, Data = DateTime.Parse(" 16 / 09 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 63, Carro = "Aenean Egestas Corp.               ", Valor = 8.142, Quantidade = 19, Data = DateTime.Parse(" 17 / 11 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 64, Carro = "Fusce Mi Lorem Consulting          ", Valor = 8.312, Quantidade = 20, Data = DateTime.Parse(" 19 / 11 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 65, Carro = "A Sollicitudin Orci PC             ", Valor = 5.864, Quantidade = 1, Data = DateTime.Parse(" 20 / 03 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 66, Carro = "Sociosqu Limited                   ", Valor = 5.985, Quantidade = 12, Data = DateTime.Parse(" 28 / 11 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 67, Carro = "Ullamcorper Duis Cursus LLC        ", Valor = 5.164, Quantidade = 7, Data = DateTime.Parse(" 22 / 12 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 68, Carro = "Nibh Lacinia LLC                   ", Valor = 7.760, Quantidade = 10, Data = DateTime.Parse(" 13 / 06 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 69, Carro = "Eu Dui Institute                   ", Valor = 7.695, Quantidade = 8, Data = DateTime.Parse(" 12 / 12 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 70, Carro = "Fringilla Purus Mauris Consulting  ", Valor = 5.845, Quantidade = 6, Data = DateTime.Parse(" 01 / 03 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 71, Carro = "Donec Tempus Lorem Industries      ", Valor = 8.472, Quantidade = 19, Data = DateTime.Parse(" 09 / 03 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 72, Carro = "Auctor Incorporated                ", Valor = 6.795, Quantidade = 1, Data = DateTime.Parse(" 04 / 10 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 73, Carro = "Enim Etiam Imperdiet Corporation   ", Valor = 6.532, Quantidade = 13, Data = DateTime.Parse(" 14 / 10 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 74, Carro = "Non Cursus Non Industries          ", Valor = 9.569, Quantidade = 16, Data = DateTime.Parse(" 25 / 10 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 75, Carro = "Ut Semper Incorporated             ", Valor = 5.760, Quantidade = 18, Data = DateTime.Parse(" 14 / 01 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 76, Carro = "Sed Malesuada Corporation          ", Valor = 6.561, Quantidade = 4, Data = DateTime.Parse(" 06 / 03 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 77, Carro = "Sed Neque Consulting               ", Valor = 7.308, Quantidade = 2, Data = DateTime.Parse(" 31 / 08 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 78, Carro = "Nisl Arcu PC                       ", Valor = 7.260, Quantidade = 8, Data = DateTime.Parse(" 19 / 06 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 79, Carro = "Euismod Est Consulting             ", Valor = 6.020, Quantidade = 11, Data = DateTime.Parse(" 27 / 10 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 80, Carro = "Leo Vivamus Ltd                    ", Valor = 5.055, Quantidade = 8, Data = DateTime.Parse(" 22 / 10 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 81, Carro = "Tristique Neque Inc.               ", Valor = 9.268, Quantidade = 13, Data = DateTime.Parse(" 25 / 02 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 82, Carro = "In Lobortis PC                     ", Valor = 5.539, Quantidade = 4, Data = DateTime.Parse(" 18 / 12 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 83, Carro = "Nunc Ltd                           ", Valor = 6.846, Quantidade = 2, Data = DateTime.Parse(" 09 / 10 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 84, Carro = "Dictum Proin Limited               ", Valor = 5.543, Quantidade = 12, Data = DateTime.Parse(" 05 / 10 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 85, Carro = "Erat Vitae LLP                     ", Valor = 5.060, Quantidade = 7, Data = DateTime.Parse(" 12 / 12 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 86, Carro = "Pellentesque Ultricies Dignissim PC", Valor = 7.971, Quantidade = 15, Data = DateTime.Parse(" 25 / 10 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 87, Carro = "Phasellus Elit Company             ", Valor = 5.350, Quantidade = 15, Data = DateTime.Parse(" 31 / 10 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 88, Carro = "Luctus Felis Ltd                   ", Valor = 9.872, Quantidade = 13, Data = DateTime.Parse(" 06 / 01 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 89, Carro = "Dui Suspendisse PC                 ", Valor = 6.878, Quantidade = 7, Data = DateTime.Parse(" 06 / 02 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 90, Carro = "Odio Associates                    ", Valor = 7.636, Quantidade = 18, Data = DateTime.Parse(" 24 / 07 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 91, Carro = "Vel Company                        ", Valor = 7.410, Quantidade = 5, Data = DateTime.Parse(" 16 / 02 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 92, Carro = "Lobortis Institute                 ", Valor = 5.110, Quantidade = 8, Data = DateTime.Parse(" 27 / 05 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 93, Carro = "Scelerisque Company                ", Valor = 7.983, Quantidade = 19, Data = DateTime.Parse(" 03 / 12 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 94, Carro = "Posuere Enim Company               ", Valor = 6.968, Quantidade = 19, Data = DateTime.Parse(" 22 / 04 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 95, Carro = "Sem Ut Corp.                       ", Valor = 6.504, Quantidade = 11, Data = DateTime.Parse(" 02 / 02 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 96, Carro = "Dui Fusce Aliquam PC               ", Valor = 7.837, Quantidade = 2, Data = DateTime.Parse(" 08 / 12 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 97, Carro = "Nisl Sem Industries                ", Valor = 6.835, Quantidade = 5, Data = DateTime.Parse(" 14 / 11 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 98, Carro = "Vitae Corp.	                     ", Valor = 7.669, Quantidade = 7, Data = DateTime.Parse(" 09 / 11 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 99, Carro = "Malesuada Incorporated             ", Valor = 5.960, Quantidade = 4, Data = DateTime.Parse(" 26 / 09 / 2019") });
            ListaDeVendas.Add(new ListaDeVendas() { ID = 100, Carro = "Mauris Ltd                        ", Valor = 8.974, Quantidade = 18, Data = DateTime.Parse(" 16 / 05 / 2019") });


        }

        #endregion

    }
}
