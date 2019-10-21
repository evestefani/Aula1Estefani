var minhaBike = { marca: "Monarque", valor: "R$ 800,00", peso: "10kg" };


$(document).ready(
    function () {
        
        $('input[name="marca"]').val(minhaBike.marca);
        $('input[name="valor"]').val(minhaBike.valor);
        $('input[name="peso"]').val(minhaBike.peso);

        

        $('input[name="btnsalvar"]').click(function () {
        var marca = minhaBike.marca = $('input[name="marca"]').val();
        var valor = minhaBike.valor = $('input[name="valor"]').val();
        var peso = minhaBike.peso = $('input[name="peso"]').val();

        alert("Marca da bike: " + marca + "\n Valor da bike : " + valor + "\nPeso da bike: " + peso);

            CleanScreen();

        });

        $('input[name="btnmostrar"]').click(function ()
        {
            alert("Marca da bike: " + minhaBike.marca + "\n Valor da bike : " + minhaBike.valor + "\nPeso da bike: " + minhaBike.peso);
        });

    }

);

function CleanScreen() {
    var meusInputs = $('input[type="text"]');

    for (var i = 0; i < meusInputs.length; i++) {
        meusInputs.val("");

    }
}