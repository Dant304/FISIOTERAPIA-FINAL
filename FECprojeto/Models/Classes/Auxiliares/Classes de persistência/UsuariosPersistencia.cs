using CamadaDeDados.Banco;
using FECprojeto.Models.Classes.Concretas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FECprojeto.Models.Classes.Auxiliares.Classes_de_persistência
{
    public class UsuariosPersistencia
    {
   
        Paciente pac = new Paciente();
        public Fisioterapeuta FisioterapeutaComCelularClasse(fisioterapeuta f)
        {     
            Sessão.SessaoSistema.userID = f.id_fis;
          
            Sessão.SessaoSistema.tipoUsuario = "fis";
            Fisioterapeuta fis = new Fisioterapeuta(f.id_fis,null,f.nome_fis,f.cel_fis,f.cpf_fis,f.rg_fis,f.email_fis,f.senha_fis,f.dados_fis,f.nasc_fis,f.adm_fis);
            Sessão.SessaoSistema.nome = f.nome_fis;
            if (f.adm_fis == false)
            {
                Sessão.SessaoSistema.Adm = false;
            }
            else
            {
                Sessão.SessaoSistema.Adm = f.adm_fis;
            }
            if (f.img_fis == null && f.sexo_fis == true)
            {
                Sessão.SessaoSistema.imagemUsuario = null;
                Sessão.SessaoSistema.imagemNull = "../imagens/homem.png";
            }
            else if (f.img_fis == null && f.sexo_fis == false)
            {
                Sessão.SessaoSistema.imagemUsuario = null;
                Sessão.SessaoSistema.imagemNull = "../imagens/mulher.jpg";
            }
            else if(f.img_fis != null)
            {
                Sessão.SessaoSistema.imagemUsuario = null;
                Sessão.SessaoSistema.imagemUsuario = fis.img_fis;
            }
            return fis;
        }
        public Fisioterapeuta FisioterapeutaSemCelularClasse(fisioterapeuta f)
        {
            Sessão.SessaoSistema.nome = f.nome_fis;
            Sessão.SessaoSistema.userID = f.id_fis;
            
            Sessão.SessaoSistema.tipoUsuario = "fis";
            Fisioterapeuta fis = new Fisioterapeuta(f.id_fis, null, f.nome_fis, f.cpf_fis, f.rg_fis, f.senha_fis, f.email_fis, f.dados_fis, f.nasc_fis, f.adm_fis);
            if (f.adm_fis == false)
            {
                Sessão.SessaoSistema.Adm = false;
            }
            else
            {
                Sessão.SessaoSistema.Adm = f.adm_fis;
            }
            if (f.img_fis == null && f.sexo_fis == true)
            {
                Sessão.SessaoSistema.imagemUsuario = null;
                Sessão.SessaoSistema.imagemNull = "../imagens/homem.png";
            }
            else if (f.img_fis == null && f.sexo_fis == false)
            {
                Sessão.SessaoSistema.imagemUsuario = null;
                Sessão.SessaoSistema.imagemNull = "../imagens/mulher.jpg";
            }
            else if (f.img_fis != null)
            {
                Sessão.SessaoSistema.imagemUsuario = fis.img_fis;
            }
            return fis;
        }

        public Paciente PacienteComCelularClasse(paciente p)
        {
            Sessão.SessaoSistema.nome = p.nome_pac;
            Sessão.SessaoSistema.userID = p.id_pac;
            Sessão.SessaoSistema.tipoUsuario = "pac";
            Paciente pac = new Paciente(p.id_pac, null, p.nome_pac, p.tel_pac, p.cel_pac, p.cpf_pac, p.rg_pac, p.email_pac, p.senha_pac, p.dados_pac, p.nasc_pac);
            if (p.img_pac == null && p.sexo_pac == true)
            {
                Sessão.SessaoSistema.imagemUsuario = null;
                Sessão.SessaoSistema.imagemNull = "../imagens/homem.png";
            }
            else if(p.img_pac == null && p.sexo_pac == false)
            {
                Sessão.SessaoSistema.imagemUsuario = null;
                Sessão.SessaoSistema.imagemNull = "../imagens/mulher.jpg";
            }
            else if(p.img_pac != null)
            {
                Sessão.SessaoSistema.imagemUsuario = pac.img_pac;
            }
            return pac;
        }
        public Paciente PacienteSemCelularClasse(paciente p)
        {
            Sessão.SessaoSistema.nome = p.nome_pac;
            Sessão.SessaoSistema.userID = p.id_pac;
            Sessão.SessaoSistema.tipoUsuario = "pac";
            Paciente pac = new Paciente(p.id_pac, null, p.nome_pac, p.tel_pac, p.cpf_pac, p.rg_pac, p.senha_pac, p.email_pac, p.dados_pac, p.nasc_pac);
            if (p.img_pac == null && p.sexo_pac == true)
            {
                Sessão.SessaoSistema.imagemUsuario = null;
                Sessão.SessaoSistema.imagemNull = "../imagens/homem.png";
            }
            else if (p.img_pac == null && p.sexo_pac == false)
            {
                Sessão.SessaoSistema.imagemUsuario = null;
                Sessão.SessaoSistema.imagemNull = "../imagens/mulher.jpg";
            }
            else if (p.img_pac != null)
            {
                Sessão.SessaoSistema.imagemUsuario = pac.img_pac;
            }
            return pac;
        }
    }
}