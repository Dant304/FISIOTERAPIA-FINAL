namespace CamadaDeDados.Banco
{
    using Newtonsoft.Json;
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

        public byte[] imagem_video { get; set; }

        [Required]
        public string url_video { get; set; }

        [Required]
        [StringLength(1000)]
        public string descricao_video { get; set; }

        public DateTime data_video { get; set; }

        public bool ativo_video { get; set; }

        public int id_cat { get; set; }

        public int id_fis { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<acessar> acessars { get; set; }
        [JsonIgnore]
        public virtual categoria_problema categoria_problema { get; set; }
        [JsonIgnore]
        public virtual fisioterapeuta fisioterapeuta { get; set; }
    }
}
