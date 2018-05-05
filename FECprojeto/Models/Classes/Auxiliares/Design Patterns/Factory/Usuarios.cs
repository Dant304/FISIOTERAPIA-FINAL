using CamadaDeDados.Banco.TabelasSQL;
using CamadaDeNegocios.Negocios;
using FECprojeto.Models.Classes.Concretas;
using FECprojeto.Models.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FECprojeto.Models.Classes.Auxiliares.Design_Patterns.Factory
{
    class Usuarios
    {
        Paciente_Negocios bp = new Paciente_Negocios();
        Fisioterapeuta_Negocios bf = new Fisioterapeuta_Negocios();
        public IUsuarios ObterUsuario(string tipo, bool comCelular,fisioterapeuta fisio,paciente pac)
        {
            IUsuarios user = null;

            if (tipo == "fisio")
            {
                if (comCelular == true)
                {
                    if(fisio.cel_fis == null)
                    {
                        user = new Fisioterapeuta(fisio.id_fis, fisio.img_fis,fisio.nome_fis, fisio.cpf_fis,fisio.rg_fis, fisio.senha_fis,fisio.email_fis, fisio.dados_fis,fisio.nasc_fis,fisio.adm_fis);
                    }
                    else if(fisio.cel_fis != null)
                    {
                        user = new Fisioterapeuta(fisio.id_fis, fisio.img_fis, fisio.nome_fis, fisio.cel_fis, fisio.cpf_fis, fisio.rg_fis, fisio.email_fis, fisio.dados_fis, fisio.nasc_fis, fisio.adm_fis);
                    }
                    else
                    {
                        throw new Exception("Não implementado");
                    }
            
                }

            }
            else if (tipo == "pac")
            {
                user = new Paciente();
            }
            else
            {
                throw new Exception("Não encontrei nada aqui");
            }
            return user;
        }
    }
}