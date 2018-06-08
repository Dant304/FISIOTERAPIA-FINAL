using CamadaDeDados.Banco;
using CamadaDeNegocios.Negocios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace FECprojeto.Models.Classes.Concretas
{
    public class Videos
    {
        /*Propriedades da classe*/
        public int idVideo { get; set; }
        public string thumbnail { get; set; }
        public string tituloVideo { get; set; }
        public string url { get; set; }
        public string descricaoVideo { get; set; }
        public DateTime dataVideo { get; set; }
        public int cat { get; set; }
        public Videos() { }
        public Videos(int id, string thumb, string title, string url, String desc, int cat)
        {

            this.idVideo = id;
            this.thumbnail = thumb;
            this.tituloVideo = title;
            this.url = url;
            this.descricaoVideo = desc;
            this.cat = cat;
        }
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
                titulo_video = v.tituloVideo,
                embed_code = v.thumbnail,
                descricao_video = v.descricaoVideo,
                data_video = DateTime.Now,
                ativo_video = true,
                id_fis = FECprojeto.Models.Classes.Auxiliares.Sessão.SessaoSistema.userID,
                id_cat = v.cat,
                id_video = v.idVideo,
            };
            vn.CadastrarVideo(dv);
        }

    }
}