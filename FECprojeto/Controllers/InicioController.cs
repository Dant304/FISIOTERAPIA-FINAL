using CamadaDeDados.Banco.Sql;
using CamadaDeDados.Banco.TabelasSQL;
using CamadaDeNegocios.Negocios;
using FECprojeto.Models.Classes.Auxiliares;
using FECprojeto.Models.Classes.Concretas;
using FECprojeto.Models.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FECprojeto.Controllers
{
    public class InicioController : Controller
    {
       
        Paciente p = new Paciente();

        // GET: Inicio
        public ActionResult Index()
        {
           
            if (Session["UsuarioPac"] != null && Session["UsuarioFisio"] == null)
            {
                
                return View(p);
            }
            else if (Session["UsuarioPac"] == null && Session["UsuarioFisio"] != null)
            {
            
                return View(f);
            }
            return RedirectToAction("Index", "Login");
        }

        public void ObterSession(Paciente p,Fisioterapeuta f)
        {
                Session["Usuario"] = true;
         
          
        }

        public ActionResult IndexFisio()
        {
            if (Session["UsuarioFisio"] != null)
            {

                return View(Session["UsuarioFisio"]);
            }
            return RedirectToAction("Index", "Login");
        }

        public ActionResult Config()
        {
            return View();
        }
        public ActionResult sair()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Index", "Inicio");
        }

        public ActionResult ViewTeste()
        {
            DadosArtigo da = new DadosArtigo();
            artigo ar = da.PegarArtigo();

            Artigos a = new Artigos
            {
                idArtigo = ar.id_artDic,
                corpoArtigo = ar.conteudo_artDic,
                dataArtigo = ar.data_artigo,
                tituloArtigo = ar.titulo_artDic
            };
            return View(a);
        }
    }
}