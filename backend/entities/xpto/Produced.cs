using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace entities.xpto
{
    [Table("vol_produced", Schema = Schema.SCHEMA_XPTO)]
    public class Produced
    {
        [Key]
        public Guid Id { get; set; }

        public double Produced1 { get; set; }
        public double Produced2 { get; set; }
        public double Produced3 { get; set; }
        public double Produced4 { get; set; }
        public double Produced5 { get; set; }
        public double Produced6 { get; set; }
        public double Produced7 { get; set; }
        public double Produced8 { get; set; }
        public double Produced9 { get; set; }
        public double Produced10 { get; set; }
        public double Produced11 { get; set; }
        public double Total { get; set; }
    }
}
