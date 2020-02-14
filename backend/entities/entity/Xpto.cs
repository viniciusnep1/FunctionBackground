using core.seedwork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace entities.entity
{
    [Table("xpto", Schema = Schema.SCHEMA_ENTIDADES)]
    public class Xpto : BaseEntity<Guid>
    {
        public Xpto()
        {
            Id = Guid.NewGuid();
        }
        public double TotalPlanned1 { get; set; } = 0;
        public double TotalProduced1 { get; set; } = 0;
        public double TotalPlanned2 { get; set; } = 0;
        public double TotalProduced2 { get; set; } = 0;
        public double TotalPlanned3 { get; set; } = 0;
        public double TotalProduced3 { get; set; } = 0;
        public double TotalPlanned4 { get; set; } = 0;
        public double TotalProduced4 { get; set; } = 0;
        public double TotalPlanned5 { get; set; } = 0;
        public double TotalProduced5 { get; set; } = 0;
        public double TotalPlanned6 { get; set; } = 0;
        public double TotalProduced6 { get; set; } = 0;
        public double TotalPlanned7 { get; set; } = 0;
        public double TotalProduced7 { get; set; } = 0;
        public double TotalPlanned8 { get; set; } = 0;
        public double TotalProduced8 { get; set; } = 0;
        public double TotalPlanned9 { get; set; } = 0;
        public double TotalProduced9 { get; set; } = 0;
        public double TotalPlanned10 { get; set; } = 0;
        public double TotalProduced10 { get; set; } = 0;
        public double TotalPlanned11 { get; set; } = 0;
        public double TotalProduced11 { get; set; } = 0;
    }
}
