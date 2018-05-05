﻿using CamadaDeDados.Banco;
using CamadaDeDados.Banco.TabelasSQL;
using CamadaDeNegocios.Negocios;
using FECprojeto.Models.Classes.Abstrata;
using FECprojeto.Models.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FECprojeto.Models.Classes.Concretas
{
    /*Classe filha : Classe Pai*/
    public class Fisioterapeuta : Pessoa , IUsuarios
    {
        /*Propriedades da classe*/

       
        public byte[] img_fis { get; set; } 
        public string senha_fis { get; set; }
        public string dados_fis { get; set; }
        public bool ativo_fis { get; set; }
        public bool adm_fis { get; set; }
        public int FKid_cli { get; set; }
        /*-------------------------------------------------------------------------------------------------------------------------------*/
        /*Construtores da classe*/
        public Fisioterapeuta()
        {

        }
        public Fisioterapeuta(int id, byte[] img_fis, string nome, string telCelular, string cpf, string rg, string email, string senha, String dadosFisio, DateTime dataDeAniversario, bool adm)
        {
            SetIdPessoa(id);
            this.nome = nome;
            this.telCelular = telCelular;
            this.cpf = cpf;
            this.rg = rg;
            this.email = email;
            this.senha_fis = senha;
            this.dados_fis = dadosFisio;
            this.dataDeAniversario = dataDeAniversario;
            this.adm_fis = adm;
        }
        public Fisioterapeuta(int id, byte[] img_fis, string nome, string cpf, string rg, string senha, string email, String dadosFisio, DateTime dataDeAniversario, bool adm)
        {
            SetIdPessoa(id);
            this.img_fis = img_fis;
            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.senha_fis = senha;
            this.email = email;
            this.dados_fis = dadosFisio;
            this.dataDeAniversario = dataDeAniversario;
            this.adm_fis = adm;
        }  
        /*-------------------------------------------------------------------------------------------------------------------------------*/
        /*Métodos da classe*/
        public void enviarArtigo(Artigos a)
        {
           Artigos_Negocios ba = new Artigos_Negocios();
            artigo art = new artigo
            {
                id_artDic = a.idArtigo,
                titulo_artDic = a.tituloArtigo,
                conteudo_artDic = a.corpoArtigo,
                data_artigo = a.dataArtigo,
                id_fis = GetIdPessoa
            };
            ba.enviarArtigo(art);
        }
        public void enviarMensagem(string mensagem)
        {

        }

        public void logar()
        {
            throw new NotImplementedException();
        }
    }
}