using CamadaDeDados.Banco;
using CamadaDeNegocios.Negocios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace FECprojeto.Models.Classes.Concretas
{
    public class Videos
    {
        /*Propriedades da classe*/
        public int idVideo { get; set; }
        public Image thumbnail { get; set; }
        public string tituloVideo { get; set; }
        public string url { get; set; }
        public string descricaoVideo { get; set; }
        public DateTime dataVideo { get; set; }

        public void eliminarVideo(int? id)
        {
            Video_Negocios vn = new Video_Negocios();
            vn.eliminarVideo(id);
        }

        public void EnviarVideo(Videos v)
        {
            Video_Negocios vn = new Video_Negocios();
            video dv = new video()
            {
                id_video = 0,
                titulo_video = v.tituloVideo,
                descricao_video = v.descricaoVideo,
                data_video = v.dataVideo,
                url_video = url,
                id_cat = 1,
                ativo_video = true,
                id_fis = FECprojeto.Models.Classes.Auxiliares.Sessão.SessaoSistema.userID,
                imagem_video = null
            };
            vn.CadastrarVideo(dv);
        }

    }
}