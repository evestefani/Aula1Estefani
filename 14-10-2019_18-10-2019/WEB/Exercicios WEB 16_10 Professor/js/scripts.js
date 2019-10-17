/*Ao carregar nosso site por completo ele executa o conteúdo $(document).ready*/
$(document).ready(
    function () {
        $('button[name=btnPressMe]').click(function () {

            /*Aqui obtemos o valor digitado pelo usuario*/
            var nomeusuario = $('input[name=campoNome]').val();
            $('span[name="usuariotext"]').text(nomeusuario);

            /*Apresentamos nosso alerta de boas vindas*/
            $('button[name=btnPressMe]').click();

          
        });
    }
);
