var minhaBike = { nome: "Lou", idade: "3 meses", raca: "SRD", coloracao: "Tigrada" };


$(document).ready(
    function () {
        
        $('input[name="nome"]').val(minhaBike.nome);
        $('input[name="idade"]').val(minhaBike.idade);
        $('input[name="raca"]').val(minhaBike.raca);
        $('input[name="coloracao"]').val(minhaBike.coloracao);
        

        $('input[name="btnsalvar"]').click(function () {
        var nome = minhaBike.nome = $('input[name="nome"]').val();
        var idade = minhaBike.idade = $('input[name="idade"]').val();
        var raca = minhaBike.raca = $('input[name="raca"]').val();
        var coloracao = minhaBike.coloracao = $('input[name="coloracao"]').val();

      

        alert("Nome do pet: " + nome + "\n Idade do pet: " + idade + "\nRaça do pet: " + raca + "\nColoração do pet: " + coloracao);

            CleanScreen();

        });

        $('input[name="btnmostrar"]').click(function ()
        {
            alert("Nome do pet: " + minhaBike.nome + "\n Idade do pet: " + minhaBike.idade + "\nRaça do pet: " + minhaBike.raca + "\nColoração do pet: " + minhaBike.coloracao);
        });

    }

);

function CleanScreen() {
    var meusInputs = $('input[type="text"]');

    for (var i = 0; i < meusInputs.length; i++) {
        meusInputs.val("");

    }
}