namespace CamadaDeDados.Banco.TabelasSQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class video
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public video()
        {
            acessars = new HashSet<acessar>();
        }

        [Key]
        public int id_video { get; set; }

        [Required]
        [StringLength(30)]
        public string titulo_video { get; set; }

        [Required]
        public byte[] midia_video { get; set; }

        [Required]
        [StringLength(1000)]
        public string descricao_video { get; set; }

        public DateTime data_video { get; set; }

        public bool ativo_video { get; set; }

        public int id_cat { get; set; }

        public int id_fis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<acessar> acessars { get; set; }

        public virtual categoria_problema categoria_problema { get; set; }

        public virtual fisioterapeuta fisioterapeuta { get; set; }
    }
}
