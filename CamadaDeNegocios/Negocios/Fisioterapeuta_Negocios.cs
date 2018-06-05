using CamadaDeDados.Banco;
using CamadaDeDados.Banco.Sql;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDeNegocios.Negocios
{
    public class Fisioterapeuta_Negocios
    {
        DadosFisioterapeuta df = new DadosFisioterapeuta();
        DadosArtigo da = new DadosArtigo();
        DadosVideo dv = new DadosVideo();
        public string MensagemDeErro()
        {
            Exception e = new Exception();
            return e.ToString();
        }
        public void SalvarFisioterapeuta(fisioterapeuta fisioterapeuta)
        {
            if (fisioterapeuta != null)
            {
                DadosFisioterapeuta df = new DadosFisioterapeuta();

                df.SalvarFisioterapeuta(fisioterapeuta);
            }
            else
            {
                throw new Exception();
            }
        }
        public void Desativar(fisioterapeuta fisioterapeuta)
        {
            DadosFisioterapeuta df = new DadosFisioterapeuta();
            if (fisioterapeuta == null)
            {

                throw new Exception();
            }
            df.Desativar(fisioterapeuta.id_fis);
        }
        public bool fazerLogin(string email, string senha)
        {
            DadosFisioterapeuta df = new DadosFisioterapeuta();
            if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(senha))
            {
                MensagemDeErro();
            }
            return df.ProcurarPorUsuario(email, senha);
        }
        public fisioterapeuta ObterPorLogin(string email, string senha)
        {
            return df.ObterPorLogin(email, senha);
        }
        public void AlterarSenha(string email, string senhaNova)
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(senhaNova))
            {
                df.AlterarSenha(email, senhaNova);
            }

        }

        public List<fisioterapeuta> ObterFisio( string nome)
        {
             return df.ObterUmFisioterapeutas(nome);
        }

        public List<fisioterapeuta> ObterSem()
        {
            return df.ObterTodosSem();
        }

        public List<artigo> TodosArtigos(int id)
        {
            return da.ObterTodosArtigos(id);
        }
        public List<video> TodosOsVideos(int id)
        {
            return dv.ListarVideos(id,null);
        }
        public List<fisioterapeuta> pesquisarFisio(string nome)
        {
           return df.ObterUmFisioterapeutas(nome);
        }
        public fisioterapeuta ObterUmFisio(int id)
        {
            return df.ObterPorId(id);
        }

        public List<video> PesquisarVideos(int id,string search)
        {
            return dv.ListarVideos(id, search);
        }
    }
}
