namespace CamadaDeDados.Banco
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fisioterapeuta")]
    public partial class fisioterapeuta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fisioterapeuta()
        {
         
        artigos = new HashSet<artigo>();
            mensagems = new HashSet<mensagem>();
            videos = new HashSet<video>();
            pacientes = new HashSet<paciente>();
            clinicas = new HashSet<clinica>();
        }

        [Key]
        public int id_fis { get; set; }

        public byte[] img_fis { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name ="Nome")]
        public string nome_fis { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Email")]
        public string email_fis { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Senha")]
        public string senha_fis { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [Display(Name = "Descrição")]
        public string dados_fis { get; set; }

        [StringLength(14)]
        [Display(Name = "Celular")]
        public string cel_fis { get; set; }

        [Required]
        [StringLength(11)]
        [Display(Name = "CPF")]
        public string cpf_fis { get; set; }

        [Required]
        [StringLength(9)]
        [Display(Name = "R.G")]
        public string rg_fis { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Data de nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}"),]
        public DateTime nasc_fis { get; set; }
        [Display(Name = "Ativo")]
        public bool ativo_fis { get; set; }
        [Display(Name = "Administrador")]
        public bool adm_fis { get; set; }
        [Display(Name = "Gênero")]
        public bool sexo_fis { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<artigo> artigos { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mensagem> mensagems { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<video> videos { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<paciente> pacientes { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<clinica> clinicas { get; set; }
    }
}
