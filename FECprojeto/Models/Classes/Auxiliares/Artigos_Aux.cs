using CamadaDeDados.Banco;
using FECprojeto.Models.Classes.Concretas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FECprojeto.Models.Classes.Auxiliares
{
    public class Artigos_Aux
    {
        public List<artigo> list { get; set; }
        public artigo art { get; set; }

        public Artigos_Aux()
        {
            Artigos_Aux art = new Artigos_Aux();
        }
    }
}