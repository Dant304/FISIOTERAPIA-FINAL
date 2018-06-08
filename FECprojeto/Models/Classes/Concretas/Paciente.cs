using CamadaDeNegocios.Negocios;
using FECprojeto.Models.Classes.Abstrata;
using System;
using System.Drawing;

namespace FECprojeto.Models.Classes.Concretas
{
    /*Classe filha : Classe Pai*/
    public class Paciente : Pessoa
    {

        /*Propriedades da classe*/

      
        public string img_pac { get; set; }
        public string senha_pac { get; set; }
        public string dados_pac { get; set; }
        public string telResidencial { get; set; }
        public string endereco_pac { get; set; }
        public bool ativo_pac { get; set; }
        /*-------------------------------------------------------------------------------------------------------------------------------*/
        /*Construtores da classe*/
        public Paciente()
        {

        }
        public Paciente(int id, string img_pac, string nome, string tel_pac, string telCelular, string cpf, string rg, string email, string senha, String dadosPac, DateTime dataDeAniversario)
        {
            SetIdPessoa(id);
            this.img_pac = img_pac;
            this.nome = nome;
            this.telCelular = telCelular;
            this.telResidencial = tel_pac;
            this.cpf = cpf;
            this.rg = rg;
            this.email = email;
            this.senha_pac = senha;
            this.dados_pac = dadosPac;
            this.dataDeAniversario = dataDeAniversario;
        }
        public Paciente(int id, string img_pac, string nome, string telResidencial, string cpf, string rg, string senha, string email, String dadosPac, DateTime dataDeAniversario)
        {
           SetIdPessoa(id);
            this.img_pac = img_pac;
            this.nome = nome;
            this.telResidencial = telResidencial;
            this.cpf = cpf;
            this.rg = rg;
            this.senha_pac = senha;
            this.email = email;
            this.dados_pac = dadosPac;
            this.dataDeAniversario = dataDeAniversario;
        }
        /*-------------------------------------------------------------------------------------------------------------------------------*/
        /*Getters e Setters*/
        public void SetSenha(string senha)
        {
            //Mudando o valor da propriedade privada.
            senha_pac = senha;
        }
        /*-------------------------------------------------------------------------------------------------------------------------------*/
        /*Métodos da classe*/
        public bool fazerLogin(string email, string senha)
        {
             Paciente_Negocios bp = new Paciente_Negocios();
            return bp.fazerLogin(email, senha);
        }
        public void receberMensagem()
        {

        }

        public void logar()
        {
            throw new NotImplementedException();
        }
    }
}