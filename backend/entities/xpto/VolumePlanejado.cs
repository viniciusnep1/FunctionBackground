using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace entities.xpto
{
    [Table("volume_planejado", Schema = Schema.SCHEMA_XPTO)]
    public class VolumePlanejado
    {
        [Key]
        public Guid Id { get; set; }
        public double DadosVolPlanejado1 { get; set; }
        public double DadosVolPlanejado2 { get; set; }
        public double DadosVolPlanejado3 { get; set; }
        public double DadosVolPlanejado4 { get; set; }
        public double DadosVolPlanejado5 { get; set; }
        public double DadosVolPlanejado6 { get; set; }
        public double DadosVolPlanejado7 { get; set; }
        public double DadosVolPlanejado8 { get; set; }
        public double DadosVolPlanejado9 { get; set; }
        public double DadosVolPlanejado10 { get; set; }
        public double DadosVolPlanejado11 { get; set; }
    }
}
