using CamadaDeDados.Banco;
using CamadaDeDados.Banco.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDeNegocios.Negocios
{
    public class Paciente_Negocios
    {
        DadosPaciente dp = new DadosPaciente();
        DadosArtigo da = new DadosArtigo();
        DadosVideo dv = new DadosVideo();
        public void SalvarPaciente(paciente paciente)
        {
            if (paciente != null)
            {
                dp.SalvarPaciente(paciente);
            }
        }
        public void Desativar(paciente paciente)
        {

            if (paciente == null)
            {
                throw new Exception("Paciente vazio");
            }
            dp.Desativar(paciente.id_pac);
        }
        public bool fazerLogin(string email, string senha)
        {

            if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(senha))
            {
                return false;
            }
            return dp.ProcurarPorUsuario(email, senha);
        }
        public paciente ObterPorLogin(string email, string senha)
        {
            return dp.ObterPorLogin(email, senha);
        }
        public List<artigo> ObterArtigosPac(int id)
        {
            return da.ObterTodosArtigos(id);
        }
        public List<video> ObterVideosPac(int id)
        {
            return dv.ListarVideos(id,null);
        }
        public List<paciente> ObterPacientes()
        {
            return dp.ObterTodosPacientes();
        }
    }
}
