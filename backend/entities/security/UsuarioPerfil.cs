using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using entities;

namespace security
{
    [Table("usuario_perfil", Schema = Schema.SCHEMA_SEGURANCA)]
    public class UsuarioPerfil : IdentityUserRole<Guid>
    {
        public virtual Usuario User { get; set; }

        public virtual Perfil Role { get; set; }
    }
}
