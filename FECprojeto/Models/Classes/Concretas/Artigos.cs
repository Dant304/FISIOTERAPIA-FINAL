﻿using CamadaDeNegocios.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FECprojeto.Models.Classes.Concretas
{
    public class Artigos
    {
        /*Propriedades da classe*/
        public int idArtigo { get; set; }
        public string tituloArtigo { get; set; }
        public string corpoArtigo { get; set; }
        public DateTime dataArtigo { get; set; }

        public void eliminarArt(int? id)
        {          
                Artigos_Negocios an = new Artigos_Negocios();
                an.eliminarArt(id);
        }
    }
}