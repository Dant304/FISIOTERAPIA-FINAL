$(document).ready(() => {
    const $cadastrarBtn = $("#cadastrarBtn");
    const $listaDeOpcoes = $("#listaDeOpcoes");

    $("#listaDeOpcoes").hide();

    $("#formFisioterapeuta").hide();
        $("#formPaciente").hide();

    $($cadastrarBtn).click(() => {
        $("#listaDeOpcoes").slideDown();
    }),

        function sairOpcoes() {
            $("#listaDeOpcoes").hide();
                   }

    $($btnFisio).click(() => {
        $("#formFisioterapeuta").slideDown();
        $("#formPaciente").slideUp();
    });
    $($btnPaci).click(() => {
        $("#formFisioterapeuta").slideUp();
        $("#formPaciente").slideDown();
    });
    
}); 

    function sair(){ 
        const sair = confirm("Quer realmente encerrar a sessão?");
        if(sair === true){
            location.href = "../index.html";
        }
        
}

function retornar() {
    location.href = "../Inicio/IndexFisioterapeuta";
}