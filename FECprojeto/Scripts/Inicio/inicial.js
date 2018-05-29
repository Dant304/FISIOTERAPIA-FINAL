
$(document).ready(() => {
    const $configBtn = $("#configBtn");
    const $inicioBtn = $("#inicioBtn");
    $("#formConfig").hide();
    $("#Inicio").show();
    $($configBtn).click(() => {
        $("#Inicio").hide();
        $("#formConfig").slideDown();

    });

});

function sair() {
    const sair = confirm("Quer realmente encerrar a sessão?");
    if (sair === true) {
        location.href = "../Login/sair";
    }
}
function config() {
    location.href = "../Inicio/Config";
}

function artigos() {
    location.href = "../Inicio/ViewTeste";
}





