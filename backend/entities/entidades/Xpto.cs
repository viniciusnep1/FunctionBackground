using core.seedwork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace entities.entidades
{
    [Table("xpto", Schema = Schema.SCHEMA_ENTIDADES)]
    public class Xpto : EntidadeBase<Guid>
    {
        public Xpto()
        {
            Ativo = true;
            DataCriacao = DateTime.Today;
            Id = Guid.NewGuid();
        }
        public double TotalDadosVolPlanejado1 { get; set; } = 0;
        public double TotalDadosVolProduzido1 { get; set; } = 0;
        public double TotalDadosVolPlanejado2 { get; set; } = 0;
        public double TotalDadosVolProduzido2 { get; set; } = 0;
        public double TotalDadosVolPlanejado3 { get; set; } = 0;
        public double TotalDadosVolProduzido3 { get; set; } = 0;
        public double TotalDadosVolPlanejado4 { get; set; } = 0;
        public double TotalDadosVolProduzido4 { get; set; } = 0;
        public double TotalDadosVolPlanejado5 { get; set; } = 0;
        public double TotalDadosVolProduzido5 { get; set; } = 0;
        public double TotalDadosVolPlanejado6 { get; set; } = 0;
        public double TotalDadosVolProduzido6 { get; set; } = 0;
        public double TotalDadosVolPlanejado7 { get; set; } = 0;
        public double TotalDadosVolProduzido7 { get; set; } = 0;
        public double TotalDadosVolPlanejado8 { get; set; } = 0;
        public double TotalDadosVolProduzido8 { get; set; } = 0;
        public double TotalDadosVolPlanejado9 { get; set; } = 0;
        public double TotalDadosVolProduzido9 { get; set; } = 0;
        public double TotalDadosVolPlanejado10 { get; set; } = 0;
        public double TotalDadosVolProduzido10 { get; set; } = 0;
        public double TotalDadosVolPlanejado11 { get; set; } = 0;
        public double TotalDadosVolProduzido11 { get; set; } = 0;
    }
}
