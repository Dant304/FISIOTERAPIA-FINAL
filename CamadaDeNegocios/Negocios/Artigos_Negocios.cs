using CamadaDeDados.Banco;
using CamadaDeDados.Banco.Sql;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDeNegocios.Negocios
{
    public class Artigos_Negocios
    {
        public void enviarArtigo(artigo a)
        {
            if (a == null)
            {
                throw new Exception("Conteúdo vazio");
            }

            DadosArtigo da = new DadosArtigo();
            da.SalvarArtigo(a);
        }

        public artigo umArtigo(int id)
        {
            DadosArtigo dart = new DadosArtigo();
            return dart.PegarArtigo(id);
        }

        public void eliminarArt(int? id)
        {
            if(id != 0)
            {
                DadosArtigo dart = new DadosArtigo();
                dart.DesativarArtigo(id);
                
            }
        }
    }
}
