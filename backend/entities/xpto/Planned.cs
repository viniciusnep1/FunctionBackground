using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace entities.xpto
{
    [Table("vol_planned", Schema = Schema.SCHEMA_XPTO)]
    public class Planned
    {
        [Key]
        public Guid Id { get; set; }
        public double Planned1 { get; set; }
        public double Planned2 { get; set; }
        public double Planned3 { get; set; }
        public double Planned4 { get; set; }
        public double Planned5 { get; set; }
        public double Planned6 { get; set; }
        public double Planned7 { get; set; }
        public double Planned8 { get; set; }
        public double Planned9 { get; set; }
        public double Planned10 { get; set; }
        public double Planned11 { get; set; }
    }
}
