using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using entities;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace security
{
    [Table("perfil", Schema = Schema.SCHEMA_SEGURANCA)]
    public partial class Perfil : IdentityRole<Guid>
    {
        [StringLength(40)]
        public override string Name
        {
            get => base.Name;
            set => base.Name = value;
        }

        public DateTime DataCriacao { get; set; }

        public DateTime DataAlteracao { get; set; }

        public bool Desativado { get; set; }

        [JsonIgnore]
        public virtual List<UsuarioPerfil> Papeis { get; set; } = new List<UsuarioPerfil>();

        [JsonIgnore]
        public virtual List<PerfilModulo> Modulos { get; set; } = new List<PerfilModulo>();

        public Perfil()
        {
            Id = Guid.NewGuid();
        }
    }
}
