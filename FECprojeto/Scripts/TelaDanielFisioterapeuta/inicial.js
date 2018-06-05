$(window).ajaxStart(function () {

    $.blockUI({ message: '<p><img style="margin-top:4%;margin-left:0%;width:15%;height:8%;" src="../imagens/200.gif" alt="Loading..." style="background-color:dodgerblue;border-radius:20%;box-shadow:black 2px 2px 20px 2px;width:10%;height:10%;"/><br\>Carregando...</p>', css: { backgroundColor: 'white', opacity: '0.8', height: '15%', borderRadius: '10%', width: '30%', boxShadow: 'white 1px 1px 20px 1px' } });

});
$(document).ajaxStart(function () {
    $.blockUI({ message: '<p><img style="margin-top:4%;margin-left:0%;width:15%;height:8%;" src="../imagens/200.gif" alt="Loading..." style="background-color:dodgerblue;border-radius:20%;box-shadow:black 2px 2px 20px 2px;width:10%;height:10%;"/><br\>Carregando...</p>', css: { backgroundColor: 'white', opacity: '0.8', height: '15%', borderRadius: '10%', width: '30%', boxShadow: 'white 1px 1px 20px 1px' } });

});
$(window).ajaxStop(function () {
    $.unblockUI();
});
$(document).ajaxStop(function () {
    $.unblockUI();
});


$(window).load(function () {
    //Ajustar

    $('#modal').append('<div id="myModal" class="modal fade" role="document" data-backdrop="static"> <div class="modal-dialog modal-lg">  <!-- Modal content--> <div style="border:solid 2px black;" class="modal-content"> <div class="modal-header" title="Fechar janela"> <h4 class="modal-title" style="text-align:center">Cadastro</h4><div style="cursor:pointer" data-dismiss="modal"> <img style="float:right;cursor:pointer;border:solid 1px black;"  src="../imagens/fechar-ou-cancelar-esboco-cruz_318-31648.jpg"/> </div>  </div> <div  class="modal-body" id="telaCadastro">  </div>  </div>  </div> </div>');
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

    $('#telaCadastro').load('../Inicio/telaCadastroFisio');

});
$(window).ready(function () {
    $.unblockUI();

});

$(document).load(function () {

    $.blockUI({ message: '<p><img style="margin-top:4%;margin-left:0%;width:15%;height:8%;" src="../imagens/200.gif" alt="Loading..." style="background-color:dodgerblue;border-radius:20%;box-shadow:black 2px 2px 20px 2px;width:10%;height:10%;"/><br\>Carregando...</p>', css: { backgroundColor: 'white', opacity: '0.8', height: '15%', borderRadius: '10%', width: '30%', boxShadow: 'white 1px 1px 20px 1px' } });
    $.ajax({
        url: '../Inicio/_videos',
        async: true,
        complete: function (data) {
            if (data === null) {
                alert('nulo');
            } else {
                alert('não nulo')
            }
        }
    })
});
function atualizar() {
    $("#partial").ready(function () {
        $.get('../Inicio/_videos', function (html) {

            $('#conteudo').append('<t');




        })
    })
}
$(document).ready(function () {

    $('#profissionaisBtn').click(function () {
        $('#submenu').slideDown();
    });

    $('#admBtn').click(function () {
        $('#submenu2').slideDown();
    });

    $('#submenu2').mouseleave(function () {
        $('#submenu2').slideUp();
    });

    $('#submenu').mouseleave(function () {
        $('#submenu').slideUp();
    });


});

  

function notifique(nome,icone, titulo, mensagem, link) {

    if (!Notification) {
        alert('Notificações desabilitadas');
        return;
    } else {
        if (Notification.requestPermission()) {  
            $(document).ready(function () {
                var notificacao = new Notification(titulo ,{
                    icon: icone,
                    body: mensagem,
                    link: link
                });
               
           
            });
      
        }
    }

}

function pegarIdVid(num) {

    $.get("../Inicio/videoDetails/" + num, function (data) {

    });
}




function descerLista() {
    $('#submenu').slideDown();
}

function sair() {
    const sair = confirm("Quer realmente encerrar a sessão?");
    if (sair === true) {
        location.href = "../Login/sair";
    }
}
function mostrarAdm() {
    $('telaAdm').show();
}
function config() {
    document.getElementById('name').innerHTML = "Configurações";

    $('#chat').hide();
    $('#partial').load('../Inicio/Config');
}
function pesquisarFisio() {
    var search = document.getElementById("pesquisa").value;
    $('[data-toggle="popover"]').popover('hide');
    $('#chat').hide();
    $('#partial').load('../Inicio/profissionalSource/' + search);
}

function videoSourcePage() {
    document.getElementById('name').innerHTML = "Videos";
    $('#chat').hide();
    $('#partial').load('../Inicio/_videos');
}

function artigosSource(id) {
    document.getElementById('name').innerHTML = "Artigos";
    $('[data-toggle="popover"]').popover('hide');
    $('#chat').hide();
    $('#partial').load('../Inicio/artigoSource');
}

function artigoDetalhes(id) {
    document.getElementById('name').innerHTML = "";

    $('#chat').hide();
    $('#partial').load('../Inicio/ArtigoDetails/' + id);
}
function videoDetalhes(id) {

    $('#partial').load('../Inicio/VideoDetails/' + id);
}
function profissionalSource() {
    document.getElementById('name').innerHTML = "Fisioterapeutas";

    $('#chat').hide();
    $('#partial').load('../Inicio/_fisioterapeutas');

}

function cancelar() {
    const cancel = confirm("Você deseja cancelar a alteração da senha?");
    if (cancel === true) {
        location.href = "../";
    }
}

function search(es) {
    var input = $('#pesquisa').val();

    $('#chat').hide();
    if (es === "fis") {
        $('#partial').load('../Inicio/_fisioterapeutas?nome=' + input);
    }
    else if (es === "vid") {
        $('#partial').load('../Inicio/_videos', { id: null, search: input })
    }
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

function TelaCadastrar() {
    //   $('#partial').modal(' <div id="myModal" class="modal fade" role="dialog"> < div class= "modal-dialog" > <div class="modal-content">  <div class="modal-header"> <button type="button" class="close" data-dismiss="modal">&times;</button>  <h4 class="modal-title">Modal Header</h4> </div> <div class="modal-body"> <p>Some text in the modal.</p></div> <div class="modal-footer"> <button type="button" class="btn btn-default" data-dismiss="modal">Close</button> </div> </div>  </div > </div ></div></div>');
    //  $('#telaCadastro').load('../Inicio/telaCadastroFisio')
}

function details(id) {
    fisioDetails(id);
}
function changeTitle(num) {
    if (num === 1) {
        document.getElementById("title").innerHTML = "Fisioterapeuta";
    } else if (num === 2) {
        document.getElementById("title").innerHTML = "Paciente";
        document.getElementById("adm").style.display = "none";
    }
}


