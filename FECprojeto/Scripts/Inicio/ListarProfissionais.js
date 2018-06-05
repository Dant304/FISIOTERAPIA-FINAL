
  function listarFis() {
      $('#table').empty();
      var search = $('#pesquisa').val();
      $.ajax({
          url: '../Inicio/listarFisio/' + $('#pesquisa').val(),
          type: 'GET',
          data: null,
          success: function (data) {
              var body = '';
              for (var i = 0; i < data.length; i++) {
                  body += '<tr><td>' + data[i].nome_fis + '</td></tr>';
              }
              alert(body);
              $('#table').html(body);
          }
      });

    

    }
