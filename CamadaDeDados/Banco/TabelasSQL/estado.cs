namespace CamadaDeDados.Banco.TabelasSQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estado")]
    public partial class estado
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string nome_state { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string sigla_state { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_pais { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_cli { get; set; }

        public virtual clinica clinica { get; set; }

        public virtual pai pai { get; set; }
    }
}
