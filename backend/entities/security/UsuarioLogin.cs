using System;
using System.ComponentModel.DataAnnotations.Schema;
using entities;
using Microsoft.AspNetCore.Identity;

namespace security
{
    [Table("usuario_login", Schema = Schema.SCHEMA_SEGURANCA)]
    public class UsuarioLogin : IdentityUserLogin<Guid>
    {

    }
}
