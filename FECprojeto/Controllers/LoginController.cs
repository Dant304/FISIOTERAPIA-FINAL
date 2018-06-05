using CamadaDeNegocios.Negocios;
using FECprojeto.Models.Classes.Auxiliares;
using FECprojeto.Models.Classes.Auxiliares.Classes_de_persistência;
using FECprojeto.Models.Classes.Auxiliares.Design_Patterns.Factory;
using FECprojeto.Models.Classes.Auxiliares.Sessão;
using System.Web.Mvc;

namespace FECprojeto.Controllers
{
    public class LoginController : Controller
    {
        
        Usuarios NovoUsuario = new Usuarios();
        Paciente_Negocios bp = new Paciente_Negocios();
        Fisioterapeuta_Negocios bf = new Fisioterapeuta_Negocios();
     
        // GET: Login
        //Redirecionamento para a tela de login, caso a sessão expire, caso contrário, permaneça logado.
        public ActionResult Index()
        {
            if (Session["UsuarioFisio"] != null)
            {
                //Redirecionando para a tela do fisioterapeuta
                return RedirectToAction("IndexFisioterapeuta", "Inicio");
            }
            else if (Session["UsuarioPac"] != null)
            {
                //Redirecionando para a tela do paciente
                return RedirectToAction("IndexPaciente", "Inicio");
            }
            else
            {
                //Tela de login
                return View("TelaDanielLogin");
            }
        }

        //Controller responsável por fazer a verificação do usuário através dos dados passados.
        [HttpGet]
        public int? logar(string login, string password)
        {
           int? conf = logarJson(login, password);
            return conf;
        }

       
        public int? logarJson(string login, string password)
        {
            //Indo as classes Paciente_Negocios e Fisioterapeuta_Negocios acionando o método para fazer login à procura do usuário.
            if (bp.fazerLogin(login, password) || bf.fazerLogin(login, password))
            {
                //Caso encontre, Abaixo será armazenado o Paciente ou o Fisioterapeuta caso seja encontrado, caso não, será null.
                var UserPac = bp.ObterPorLogin(login, password);
                var UserFisio = bf.ObterPorLogin(login, password);
                //Verificando se foi armazenado algo em 'UserPac e no UserFisio'.
                if (UserPac == null && UserFisio != null)
                {
                    //Verificando se a coluna 'cel_fis' está vazio.
                    if (UserFisio.cel_fis == null)
                    {

                        //Indo a classe Usuarios para obter um tipo de usuário para ser armazenado em fis.
                        Fisioterapeuta_Paciente fis = NovoUsuario.ObterUsuario("fisio", false, UserFisio, null);
                        //Armazenando os dados buscado na Sessão, que é identificado por 'UsuarioFisio'.
                        Session["UsuarioFisio"] = fis.Fisio;
                        //Redirecionando à tela 'IndexFisioterapeuta' do controller 'Inicio'.
                        return 1;
                    }
                    else
                    {
                        //Caso a coluna 'cel_fis' esteja com algum valor.
                        Fisioterapeuta_Paciente fis = NovoUsuario.ObterUsuario("fisio", true, UserFisio, null);
                        Session["UsuarioFisio"] = fis.Fisio;
                        return 2;
                    }
                }
                //Caso o 'UserPac' esteja com algum valor e o 'UserFisio' não.
                else if (UserPac != null && UserFisio == null)
                {
                    //Verificando se a coluna 'cel_pac' esteja sem valor.
                    if (UserPac.cel_pac == null)
                    {
                        //Indo a classe Usuarios para obter um tipo de usuário para ser armazenado em pac.
                        Fisioterapeuta_Paciente pac = NovoUsuario.ObterUsuario("pac", false, null, UserPac);
                        //Armazenando os dados buscado na Sessão, que é identificado por 'UsuarioPac'.
                        Session["UsuarioPac"] = pac.pac;
                        //Redirecionando à tela 'IndexPaciente' do controller 'Inicio'.
                        return 3;
                    }
                    else
                    {
                        //Caso a coluna 'cel_pac' esteja com algum valor.
                        Fisioterapeuta_Paciente pac = NovoUsuario.ObterUsuario("pac", true, null, UserPac);
                        Session["UsuarioPac"] = pac.pac;
                        return 4;
                    }
                }
            }
            //Caso não seja encontrado o email e a senha passada.

            //Enviará para a View a mensagem abaixo.
            ViewBag.mensagem = "Usuário não cadastrado no sistema.";

            //Retornando a ActionResult 'Index' que é a tela de login.
            return null;
        }
        //Controller responsável por descartar a sessão
        public ActionResult sair()
        {
         
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }

       
    }
}
