
$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {
                var cep = $('input[name="cep"]').val();

                $.get("https://viacep.com.br/ws/" + cep + "/json/", function (data) {

                    if (data.erro) {

                        alert("CEP Inválido");
                        return false;
                    }
               
                    $('input[name="logradouro"]').val(data.logradouro);
                    $('input[name="complemento"]').val(data.complemento);
                    $('input[name="bairro"]').val(data.bairro);
                    $('input[name="localidade"]').val(data.localidade);
                    $('input[name="uf"]').val(data.uf);
                    $('input[name="unidade"]').val(data.unidade);
                    $('input[name="ibge"]').val(data.ibge);
                    $('input[name="gia"]').val(data.gia);
                });
            });
    }
);