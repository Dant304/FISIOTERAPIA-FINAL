$(document).ajaxStart(function () {
    $.blockUI({ message: '<p><img style="margin-top:4%;margin-left:0%;width:15%;height:8%;" src="../imagens/200.gif" alt="Loading..." style="background-color:dodgerblue;border-radius:20%;box-shadow:black 2px 2px 20px 2px;width:10%;height:10%;"/><br\>Carregando...</p>', css: { backgroundColor: 'white', opacity: '0.8', height: '15%', borderRadius: '10%', width: '30%', boxShadow: 'white 1px 1px 20px 1px' } });
    $('#partial').fadeOut(100);
    $('#partial').css({ 'z-index': 1 });
});

$(document).ajaxStop(function () {
    $('#partial').fadeIn(900);
    $('#partial').css({ 'z-index': 1000 });
    $('body').fadeOut(100);
    
    $.unblockUI(); 
    window.location.reload();
});


$(window).ready(function () {
    $('#sobreContent').hide(),
        $('#container').css({ "border": "solid 1px red", "box-shadow": "red 1px 1px 20px 1px" });
    $('#login').click(function () {
        $('#container').slideUp();
    }),
        $('#password').click(function () {
            $('#container').slideUp();
        });

    $('#logar').click(function () {


        var login = document.getElementById('login').value;
        var senha = document.getElementById('password').value;

        if (login === "" && senha === "" || login === undefined && senha === undefined) {
            console.log('S E vazios'),
                $('#login').css({ "border": "solid 1px red", "box-shadow": "red 1px 1px 20px 1px" }),
                $('#password').css({ "border": "solid 1px red", "box-shadow": "red 1px 1px 20px 1px" }),
                document.getElementById('info').innerHTML = "*Campos 'login' e 'senha' vazios!";

            $('#container').slideDown();
        } else if (login === "" || login === undefined) {
            $('#password').removeAttr('style');
            $('#login').css({ "border": "solid 1px red", "box-shadow": "red 1px 1px 20px 1px" }),
                document.getElementById('info').innerHTML = "*Campo 'login' vazio!",
                $('#container').slideDown(),
                console.log('E vazio');
        } else if (senha === "" || senha === undefined) {
            $('#password').css({ "border": "solid 1px red", "box-shadow": "red 1px 1px 20px 1px" }),
                $('#alerta').slideDown(),
                $('#login').removeAttr('style'),
                document.getElementById('info').innerHTML = "*Campo 'senha' vazio!",
                $('#container').slideDown(),
                console.log('S vazio');
        }
        else {
            $('#password').removeAttr('style');
            $('#login').removeAttr('style');
            $.get("../Login/logar", { login: login, password: senha }, function (data) {
                console.log(data);

                if (data === null) {
                    document.getElementById('info').innerHTML = "Dados não encontrados1!";
                    $('#container').slideDown();
                }
                else {
                    if (data.value === 1) {
                        $(location).attr("../Inicio/IndexFisioterapeuta");
                        console.log('Fisio sem celular');

                    }
                    else if (data.value === 2) {

                        $("body").fadeIn(1000, function () {
                            window.location = "../Inicio/IndexFisioterapeuta";
                        });


                        console.log('Fisio com celular');

                    }
                    else if (data.value === 3) {
                        $(location).attr("../Inicio/IndexPaciente");
                        console.log('Pac sem celular');

                    }
                    else if (data.value === 4) {
                        $(location).attr("../Inicio/IndexPaciente");
                        console.log('Pac com celular');

                    }
                }

            }



            );
        }


    });


});

    

$(window).load(function () {
    document.addEventListener('DOMContentLoaded', function () {
        Notification.requestPermission('Deseja ativar as notificações?');
    });
    $('#sobreContent').hide();
    $('#container').hide();
});

$(document).ready(function () {
    $('#sobreBtn').click(function () {
        $('#container').hide();
        $('.form').hide();
        $('#sobreContent').slideToggle();
    });
    $('#loginBtn').click(function () {
        $('.form').show();
        $('#sobreContent').hide();
    });



});




