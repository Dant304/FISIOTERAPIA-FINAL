namespace CamadaDeDados.Banco.TabelasSQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("acessar")]
    public partial class acessar
    {
        [Key]
        public int qtnd_linha { get; set; }

        public int? id_pac { get; set; }

        public int? id_video { get; set; }

        public int? id_artDic { get; set; }

        public int? id_mensagem { get; set; }

        public virtual artigo artigo { get; set; }

        public virtual mensagem mensagem { get; set; }

        public virtual paciente paciente { get; set; }

        public virtual video video { get; set; }
    }
}
