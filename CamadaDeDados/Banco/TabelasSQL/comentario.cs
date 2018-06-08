namespace CamadaDeDados.Banco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comentario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_com { get; set; }

        [Column("comentario", TypeName = "text")]
        [Required]
        public string comentario1 { get; set; }

        public bool ativo { get; set; }
    }
}
