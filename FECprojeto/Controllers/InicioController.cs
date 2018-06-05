using CamadaDeDados.Banco;
using CamadaDeDados.Banco.Sql;

using CamadaDeNegocios.Negocios;
using FECprojeto.Models.Classes.Auxiliares.Classes_de_persistência;
using FECprojeto.Models.Classes.Auxiliares.Design_Patterns.Factory;
using FECprojeto.Models.Classes.Auxiliares.Sessão;
using FECprojeto.Models.Classes.Concretas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace FECprojeto.Controllers
{
    public class InicioController : Controller
    {
        Fisioterapeuta_Negocios fn = new Fisioterapeuta_Negocios();
        Paciente_Negocios pn = new Paciente_Negocios();
        DadosArtigo art = new DadosArtigo();
        // GET: Inicio
        //Acessando a tela inicial
        public ActionResult IndexPaciente()
        {
            if (Session["UsuarioPac"] != null)
            {

                return View("TelaDanielPaciente", Session["UsuarioPac"]);
            }
            return RedirectToAction("Index", "Login");
        }
        //Duplicata da mesma da mesma tela inicial
        public ActionResult IndexFisioterapeuta()
        {

            if (Session["UsuarioFisio"] != null)
            {
                return View("TelaDanielFisioterapeuta", Session["UsuarioFisio"]);
            }
            return RedirectToAction("Index", "Login");
        }

        //Retornando à tela de configuração
        public PartialViewResult Config()
        {
            return PartialView("_config");
        }
        public PartialViewResult telaVideo(int id)
        {
            return PartialView("_videosDetalhe", VideoDetails(id));
        }
        //Artigo
        public List<artigo> ListarArtigos()
        {
            var varios = new List<artigo>();
            int id = Convert.ToInt32(Session["id"]);
            if (Session["UsuarioFisio"] != null)
            {
                varios = fn.TodosArtigos(id);
            }
            else if (Session["UsuarioPac"] != null)
            {
                varios = pn.ObterArtigosPac(id);
            }

            return varios;
        }
        //Detalhes do artigo
        public PartialViewResult ArtigoDetails(int id)
        {
            Artigos_Negocios art = new Artigos_Negocios();
            var artigo = art.umArtigo(id);
            return PartialView("_artigoDetalhes", artigo);
        }

        public PartialViewResult VideoDetails(int id)
        {
            Video_Negocios vid = new Video_Negocios();
            var video = vid.umAVideo(id);
            return PartialView("_videosDetalhe", video);
        }
        public PartialViewResult fisioEdit(int id)
        {
            fisioterapeuta fis = fn.ObterUmFisio(id);
            return PartialView("_fisioterapeutaEdit", fis);
        }
        public List<video> videoSource(string search)
        {
            var varios = new List<video>();
            int id = Convert.ToInt32(Session["id"]);
            if (Session["UsuarioFisio"] != null)
            {
                if (search == null || search == "")
                {
                    varios = fn.TodosOsVideos(id);
                }
                else
                {
                    varios = fn.PesquisarVideos(id, search);
                }

            }
            else if (Session["UsuarioPac"] != null)
            {
                varios = pn.ObterVideosPac(id);
            }

            return varios;
        }
        List<video> varios;
        public ActionResult _videos(int? id, string search)
        {

            if (id != null || id != 0)
            {

                if (search != "" || search != null)
                {
                    varios = videoSource(search);
                }
                else
                    varios = videoSource(null);

            }
            else
            {
                eliminarVideo(id);
            }


            return PartialView(varios);
        }

        public void eliminarVideo(int? id)
        {
            Videos vid = new Videos();
            vid.eliminarVideo(id);
        }
        public PartialViewResult artigoSource(int? id)
        {
            List<artigo> varios = ListarArtigos();
            if (varios.Count == 0)
            {
                ViewBag.mensagem = "Não há artigos publicados";
            }
            if (id != null)
            {
                eliminarArtigo(id);
            }

            return PartialView("_artigo", varios);
        }

        public PartialViewResult _fisioterapeutas(string nome)
        {
            List<fisioterapeuta> search;
            if (nome == null)
            {
                search = fn.ObterSem();
            }
            else
            {
                search = fn.pesquisarFisio(nome);
            }

            return PartialView(search);
        }

        public PartialViewResult _fisioterapeutaDetails(int id)
        {
            fisioterapeuta search = null;
            if (id != 0)
            {
                search = fn.ObterUmFisio(id);
            }
            return PartialView(search);
        }

        [HttpPost]
        public ActionResult AlterarSenha(string email, string senhaAtual, string senhaNova, string senhaNova1)
        {

            if (senhaNova == senhaNova1)
            {
                var usuarioF = fn.ObterPorLogin(email, senhaAtual);
                var usuarioP = pn.ObterPorLogin(email, senhaAtual);
                if (usuarioF == null && usuarioP == null)
                {
                    ViewBag.mensagem = "Os dados fornecidos não foram encontrados";
                }
                else
                {
                    if (usuarioF.email_fis == email && usuarioF.senha_fis == senhaAtual)
                    {
                        fn.AlterarSenha(email, senhaNova);
                        ViewBag.mensagem = "Dados alterados com sucesso.";
                    }
                    else if (usuarioP.email_pac == email && usuarioP.senha_pac == senhaAtual)
                    {

                    }
                }
            }
            else
            {
                ViewBag.mensagem = "Senhas diferentes.";
            }

            return View("_config");
        }

        public PartialViewResult telaCadastroFisio()
        {
            return PartialView("_fisioterapeutaCreate");
        }
        public PartialViewResult Chat()
        {
            return PartialView();
        }
        public PartialViewResult _profissionalSource(string nome)
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult listarFisio(string nome)
        {

            Fisioterapeuta_Negocios business = new Fisioterapeuta_Negocios();
            var ret = JsonConvert.SerializeObject(business.ObterFisio(nome), Formatting.Indented, new JsonSerializerSettings
            {
                //Ignorando referência circular
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            //Retornando objeto em JSON
            return Json(ret, JsonRequestBehavior.AllowGet);
        }

        // public List<fisioterapeuta> lista(string nome)
        //    {
        //      Fisioterapeuta_Negocios business = new Fisioterapeuta_Negocios();
        //      var fisio = new fisioterapeuta { nome_fis = nome };
        // var ret = business.ObterFisio(fisio);
        //    var ret = business.ObterFisio(fisio);

        //  return ret;
        //   }

        //  public PartialViewResult _profissionalSource()
        //  {

        //     if (Session["UsuarioFisio"] != null)
        //   {
        //       Fisioterapeuta_Negocios fn = new Fisioterapeuta_Negocios();
        //       var f = fn.ObterSem();
        //       return PartialView("_fisioterapeutas", f);
        //    }else if (Session["UsuarioPac"] != null)
        // {
        //        Paciente =
        //     }

        //   }

        //   public List<fisioterapeuta> fisio()
        //  {

        //  }

        public void eliminarArtigo(int? id)
        {
            Artigos art = new Artigos();
            art.eliminarArt(id);
        }
        [HttpPost]
        public ActionResult Oi(HttpPostedFileBase file)
        {

            try
            {
                if (file.ContentLength > 0)
                {
                    int fl = file.ContentLength;
                    byte[] array = new byte[fl];
                    file.InputStream.Read(array, 0, fl);


                }
                ViewBag.Message = "File Uploaded Successfully!!";
                return RedirectToAction("View", "PageNotFound");
            }
            catch
            {
                ViewBag.Message = "File upload failed!!";
                return RedirectToAction("View", "PageNotFound");
            }

        }
        public PartialViewResult _novoVideo()
        {
            return PartialView();
        }
        [HttpGet]
        public RedirectToRouteResult CadastrarVideo(HttpPostedFileBase[] foto)
        {
            byte[] imagem = null;
            using(var bin = new BinaryReader(fot))
            DadosVideo dv = new DadosVideo();
            
                
           
            return RedirectToAction("_videos");
        }
        public string sessaoTime()
        {
            return Session.Timeout.ToString();
        }

    }
}



