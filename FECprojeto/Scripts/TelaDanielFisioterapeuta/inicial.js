$(document).ajaxStart(function () {
    $('#ajaxBusy').show();
});
$(document).ajaxStop(function () {
    $('#ajaxBusy').hide();
});
$(document).ready(function () {
    $('body').append('<div id="ajaxBusy" style="display:none"><p><img src="../imagens/200.gif" alt="Loading..."/>Carregando...</p></div>');

    $('#ajaxBusy').css({
        display: "none",
        margin: "0px",
        paddingLeft: "0px",
        paddingRight: "0px",
        paddingTop: "0px",
        paddingBottom: "0px",
        position: "absolute",
        left: "50%",
        top: "50%",
        width: "50%",
        height: "50%"
    });

    $('#profissionaisBtn').click(function () {
        $('#submenu').slideDown();
    });

    $('#admBtn').click(function () {
        $('#submenu2').slideDown();
    });

    $('#admBtn').mouseleave(function () {
        $('ul').slideUp();
    })

    $('#submenu2').mouseleave(function () {
        $('ul').slideUp();
    })

    $('#submenu').mouseleave(function () {
        $('ul').slideUp();
    })

    $('#profissionaisBtn').mouseleave(function () {
        $('ul').slideUp();
    })

});

function descerLista() {
    $('#submenu').slideDown()
}

function descerLista() {
    
}

function modal() {
    $('#myModal').show();
}

function sair() {
    const sair = confirm("Quer realmente encerrar a sessão?");
    if (sair === true) {
        location.href = "../Login/sair";
    }
}
function mostrarAdm() {
    $('telaAdm').show()
}
function config() {
    document.getElementById('name').innerHTML = "Configurações";
    $('#partial').load('../Inicio/Config')
}
function pesquisarFisio() {
    var search = document.getElementById("pesquisa").value;
    $('#partial').load('../Inicio/profissionalSource/' + search)
}
function videoSourcePage() {
    document.getElementById('name').innerHTML = "Videos";
    $('#partial').load('../Inicio/_videos')
}

function artigosSource(id) {
    document.getElementById('name').innerHTML = "Artigos";
    $('#partial').load('../Inicio/artigoSource')
}

function artigoDetalhes(id) {
    document.getElementById('name').innerHTML = "";
    $('#partial').load('../Inicio/ArtigoDetails/' + id)
}
function videoDetalhes(id) {
    document.getElementById('name').innerHTML = "";
        $('#partial').load('../Inicio/videoDetails/' + id)
}
function profissionalSource() {
    document.getElementById('name').innerHTML = "Fisioterapeutas";
    $('#partial').load('../Inicio/_fisioterapeutas')
   
}

function cancelar() {
    const cancel = confirm("Você deseja cancelar a alteração da senha?");
    if (cancel === true) {
        location.href = "../";
    }
}

function search() {
    var input = $('#pesquisa').val();
    $('#partial').load('../Inicio/_fisioterapeutas?nome=' + input);
}
function adm() {
    location.href = "../Adm/Index";
}

function exclusao(id) {
    const ok = confirm("Têm certeza que deseja eliminar este artigo?");
    if (ok === true) {
        location.href = "../inicio/artigoSource?id=" + id;
       
    }
}

function PegarPorId(id) {
    $('#partial').load('../Inicio/fisioEdit/' + id);
}

function fisioDetails(id) {
    $('#partial').load('../Inicio/_fisioterapeutaDetails/' + id);
}

function Inicio() {
    location.href = "../";
}


