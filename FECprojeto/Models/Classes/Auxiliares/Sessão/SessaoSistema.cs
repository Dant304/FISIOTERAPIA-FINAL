using FECprojeto.Models.Classes.Concretas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace FECprojeto.Models.Classes.Auxiliares.Sessão
{
    public static class SessaoSistema
    {
        public static string nome { get; set; }
        public static string tipoUsuario
        {
            get
            {
                try
                {
                    return Convert.ToString(HttpContext.Current.Session["user"]);
                }
                catch
                {
                    return "";
                }
            }
            set
            {
                HttpContext.Current.Session["user"] = value;
            }
        }
        public static int userID
        {
            get
            {
                try
                {
                    return Convert.ToInt32(HttpContext.Current.Session["id"]);
                }
                catch
                {
                    return 0;
                }
            }
            set
            {
                HttpContext.Current.Session["id"] = value;
            }
        }
        public static bool Adm
        {
            get
            {
                try
                {
                    return Convert.ToBoolean(HttpContext.Current.Session["adm"]);
                }
                catch
                {
                    return false;
                }
            }
            set
            {
                HttpContext.Current.Session["adm"] = value;
            }
        }
        public static string imagemUsuario;
        public static string imagemNull;
       

    }
}