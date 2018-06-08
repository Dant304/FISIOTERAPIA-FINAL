namespace CamadaDeDados.Banco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class opiniao_pac_fis
    {
        public int? id_fis { get; set; }

        [Column(TypeName = "text")]
        public string opiniao { get; set; }

        public int? id_pac { get; set; }

        public DateTime? datahora { get; set; }

        [Key]
        public bool ativo_opiniao { get; set; }

        public virtual fisioterapeuta fisioterapeuta { get; set; }

        public virtual paciente paciente { get; set; }
    }
}
