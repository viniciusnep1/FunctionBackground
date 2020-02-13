using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using entities;
using Newtonsoft.Json;
using core.seedwork;

namespace seguranca
{
    [Table("modulo_permissao", Schema = Schema.SCHEMA_SEGURANCA)]
    public class PerfilModuloPermissao : EntidadeBase
    {
        [ForeignKey(nameof(PerfilModulo))]
        public Guid PerfilModuloId { get; set; }

        [JsonIgnore]
        public virtual PerfilModulo PerfilModulo { get; set; }

        [ForeignKey(nameof(Permissao))]
        public Guid PermissaoId { get; set; }

        [JsonIgnore]
        public virtual Permissao Permissao { get; set; }

        public PerfilModuloPermissao()
        {

        }
    }
}
