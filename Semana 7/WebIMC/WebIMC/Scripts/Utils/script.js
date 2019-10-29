$(document).ready(
    function () {

        $('input[name="btncalcular"]').click(function () {
            console.log($('#formenviar'))
        var informacoes = $('#formenviar').serializeArray();

        $.get(`http://localhost:62192/api/CalculoIMC?Altura=${informacoes[2].value}&Peso=${informacoes[1].value}&Nome=${informacoes[0].value}`, function (data) {
            $('#input_modal').val(data)
        });
    });
});