using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using entities;
using core.seedwork;
using core.seedwork.interfaces;

namespace seguranca
{
    [Table("usuario", Schema = Schema.SCHEMA_SEGURANCA)]
    public partial class Usuario : IdentityUser<Guid>, IEntidadeBase<Guid>
    {
        [StringLength(40)]
        [Required]
        public string Nome { get; set; }

        [StringLength(40)]
        public override string Email
        {
            get => base.Email;
            set => base.Email = value;
        }

        [StringLength(14)]
        public string CpjCnpj { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime DataAlteracao { get; set; }

        public bool Desativado { get; set; }

        [JsonIgnore]
        public virtual List<UsuarioPerfil> Papeis { get; set; } = new List<UsuarioPerfil>();


        public Usuario()
        {
            Id = Guid.NewGuid();
        }
    }
} 
