
$(document).ready(
    function () {
    /*Chamamos nossa função de intervalo*/
        atualizaData();
            });

/*Criamos nossa primeira função*/
function atualizaData() {
    /*Agor adicionamos a função dentro do nosso context setInterval*/
    setInterval(function () {
        $('span[name="data_atual"]').text(Date());
    }, 100);
}