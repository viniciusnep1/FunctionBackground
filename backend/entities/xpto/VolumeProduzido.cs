using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace entities.xpto
{
    [Table("volume_produzido", Schema = Schema.SCHEMA_XPTO)]
    public class VolumeProduzido
    {
        [Key]
        public Guid Id { get; set; }

        public double DadosVolProduzido1 { get; set; }
        public double DadosVolProduzido2 { get; set; }
        public double DadosVolProduzido3 { get; set; }
        public double DadosVolProduzido4 { get; set; }
        public double DadosVolProduzido5 { get; set; }
        public double DadosVolProduzido6 { get; set; }
        public double DadosVolProduzido7 { get; set; }
        public double DadosVolProduzido8 { get; set; }
        public double DadosVolProduzido9 { get; set; }
        public double DadosVolProduzido10 { get; set; }
        public double DadosVolProduzido11 { get; set; }
        public double Total { get; set; }
    }
}
