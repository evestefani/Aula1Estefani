
$(document).ready(
    function () {
    /*Chamamos nossa fun��o de intervalo*/
        atualizaData();
            });

/*Criamos nossa primeira fun��o*/
function atualizaData() {
    /*Agor adicionamos a fun��o dentro do nosso context setInterval*/
    setInterval(function () {
        $('span[name="data_atual"]').text(Date());
    }, 100);
}