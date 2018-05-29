namespace CamadaDeDados.Banco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mensagem")]
    public partial class mensagem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mensagem()
        {
            acessars = new HashSet<acessar>();
        }

        [Key]
        public int id_mensagem { get; set; }

        [Required]
        [StringLength(50)]
        public string titulo_mensagem { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string conteudo_mensagem { get; set; }

        public bool ativo_mensagem { get; set; }

        public DateTime data_mensagem { get; set; }

        public int id_fis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<acessar> acessars { get; set; }

        public virtual fisioterapeuta fisioterapeuta { get; set; }
    }
}
