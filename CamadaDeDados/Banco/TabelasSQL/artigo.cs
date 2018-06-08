namespace CamadaDeDados.Banco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("artigos")]
    public partial class artigo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public artigo()
        {
            acessars = new HashSet<acessar>();
        }

        [Key]
        public int id_artDic { get; set; }

        [Required]
        [StringLength(50)]
        public string titulo_artDic { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string conteudo_artDic { get; set; }

        public bool ativo_artigo { get; set; }

        public DateTime data_artigo { get; set; }

        public int id_cat { get; set; }

        public int id_fis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<acessar> acessars { get; set; }

        public virtual categoria_problema categoria_problema { get; set; }

        public virtual fisioterapeuta fisioterapeuta { get; set; }
    }
}
