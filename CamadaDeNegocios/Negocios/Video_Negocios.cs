using CamadaDeDados.Banco;
using CamadaDeDados.Banco.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDeNegocios.Negocios
{
    public class Video_Negocios
    {
        public List<video> ListarVideos(int id)
        {
            DadosVideo dv = new DadosVideo();
           return dv.ListarVideos(id);
        }

        public video umAVideo(int id)
        {
            DadosVideo dav = new DadosVideo();
            return dav.PegarVideo(id);
        }
        public void eliminarVideo(int? id)
        {
            DadosVideo dv = new DadosVideo();
            dv.desativarVideo(id);
        }
    }
}
