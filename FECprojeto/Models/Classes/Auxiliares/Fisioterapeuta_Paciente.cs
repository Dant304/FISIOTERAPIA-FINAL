using CamadaDeNegocios.Negocios;
using FECprojeto.Models.Classes.Abstrata;
using FECprojeto.Models.Classes.Concretas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FECprojeto.Models.Classes.Auxiliares
{
    public class Fisioterapeuta_Paciente
    {
        public List<Fisioterapeuta> fisio { get; set; }
        public List<Paciente> pac { get; set; }

    }
}