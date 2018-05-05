

using CamadaDeDados.Banco.TabelasSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDeDados.Banco.Sql
{

    public class DadosArtigo : bancoSQL
    {
        /*Método para salvar/atualizar*/
        public artigo SalvarArtigo(artigo artigo)
        {
            try
            {
                /*Caso o id do artigo for igual a zero, adicione ele a tabela artigo*/
                if (artigo.id_artDic == 0)
                {
                    db.artigos.Add(artigo);
                }
                else
                {
                    /*Senão, atualize ou sobreponha os registros alterados*/
                    db.artigos.Attach(artigo);
                    db.Entry(pacientes).State = System.Data.Entity.EntityState.Modified;
                }
                /*Salvando as alterações*/
                db.SaveChanges();
            }
            catch (System.Exception ex)
            {

                throw ex;
            }

            return artigo;
        }

        //De um ou de todos os fisioterapeutas. 
        public List<artigo> ObterTodosArtigos(int id)
        {
         
            if (id == 0)
            {
                //Retornar vários artigos que estejam ativos na tabela.
                return ( from art in db.artigos where art.ativo_artigo == true select art).ToList();
            }
            else
            {
                //Retornar vários artigos de um fisioterapeuta em específico e que estejam ativos na tabela. 
                return (from art in db.artigos where art.id_artDic == id && art.ativo_artigo == true select art).ToList();
            }

        }

        //Desativando("excluir") um artigo da tabela.
        public void DesativarArtigo(int id, bool desativar)
        {
            db.Database.ExecuteSqlCommand(@"update artigo_dica set ativo_artDic = {0} where id_art = {1}",desativar,id);
        }

        public artigo PegarArtigo()
        {
            return (from art in db.artigos where art.id_artDic == 4 select art).FirstOrDefault();
        }
    }
}


