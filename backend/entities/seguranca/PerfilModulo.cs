using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using entities;
using Newtonsoft.Json;
using core.seedwork;
using System.Collections.Generic;

namespace seguranca
{
    [Table("perfil_modulo", Schema = Schema.SCHEMA_SEGURANCA)]
    public class PerfilModulo : EntidadeBase
    {
        [ForeignKey(nameof(Perfil))]
        public Guid PerfilId { get; set; }

        [JsonIgnore]
        public virtual Perfil Perfil { get; set; }

        [ForeignKey(nameof(Modulo))]
        public Guid ModuloId { get; set; }

        [JsonIgnore]
        public virtual Modulo Modulo { get; set; }

        [JsonIgnore]
        public virtual List<PerfilModuloPermissao> Permissoes { get; set; } = new List<PerfilModuloPermissao>();
        
        public PerfilModulo()
        {

        }
    }
}
