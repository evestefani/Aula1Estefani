/*Ao carregar nosso site por completo ele executa o conteúdo $(document).ready*/
$(document).ready(
    function () {
        $('input[name=btnconverter]').click(function () {

            var url = "https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-16-2019%27&$top=100&$format=json"

            $.getJSON(url, function (data) {

                var valordolar = data.value[0].cotacaoVenda;
                /*Obter um valor*/
                var valoreal = $('input[name="valoreal"]').val().replace(".", "").replace(",", ".");

                var convercao = (valoreal / valordolar)
                    .toLocaleString("en-US", { minimumFractionDigits: 2, currency: "USD" });

                /*Inserir um valor*/
                $('input[name="valordolar"]').val(convercao);

             });

        });

        $('input[name="valoreal"]').maskMoney({ showSymbol: false, symbol: "R$", decimal: ",", thousands: "." });

    }

);
