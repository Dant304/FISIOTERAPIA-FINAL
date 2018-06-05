

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDeDados.Banco.Sql
{ /*Método para salvar/atualizar*/
    public class DadosVideo : bancoSQL
    {
        //Método para Salvar/Atualizar 
        public video SalvarVideo(video video)
        {
            try
            {
                //Caso o id do video venha com 0, salve ele na tabela video.
                if (video.id_video == 0)
                {
                    db.videos.Add(video);
                }
                else
                {
                    //Senão atualize.
                    db.videos.Attach(video);
                    db.Entry(pacientes).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
            catch (System.Exception ex)
            {

                throw ex;
            }

            return video;
        }

        public List<video> ListarVideos(int id, string search)
        {
            if (id != 0)
            {
                if (search == null || search == "")
                {
                    return (from v in db.videos where v.id_fis == id orderby v.id_video ascending select v).ToList();
                }
                else if (search != null || search != "")
                {
                    return (from v in db.videos where v.titulo_video.Contains(search) orderby v.titulo_video select v).ToList();
                }

            }

            return null;
        }
        public video PegarVideo(int id)
        {
            return (from v in db.videos where v.id_video == id select v).FirstOrDefault();
        }
        public void desativarVideo(int? id)
        {
            if (id != null)
            {
                bool desativar = false;
                db.Database.ExecuteSqlCommand(@"update videos set ativo_video = {0} where id_video = {1}", desativar, id);
            }

        }
    }
}



