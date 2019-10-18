var meuPet = { nome: "Lou", idade: "3 meses", raca: "SRD", coloracao: "Tigrada" };

$(document).ready(
    function () {
        
        $('input[name="nome"]').val(meuPet.nome);
        $('input[name="idade"]').val(meuPet.idade);
        $('input[name="raca"]').val(meuPet.raca);
        $('input[name="coloracao"]').val(meuPet.coloracao);
        

        $('input[name="btnsalvar"]').click(function () {
        var nome = meuPet.nome = $('input[name="nome"]').val();
        var idade = meuPet.idade = $('input[name="idade"]').val();
        var raca = meuPet.raca = $('input[name="raca"]').val();
        var coloracao = meuPet.coloracao = $('input[name="coloracao"]').val();

        alert("Nome do pet: " + nome + "\nIdade do pet: " + idade + "\nRaça do pet: " + raca + "\nColoração do pet: " + coloracao);

        });

        $('input[name="btnmostrar"]').click(function () {
            alert("Nome do pet: " + nome + "\nIdade do pet: " + idade + "\nRaça do pet: " + raca + "\nColoração do pet: " + coloracao);
        });

    }

);