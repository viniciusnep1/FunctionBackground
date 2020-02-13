using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using entities;
using core.seedwork;

namespace seguranca
{
    [Table("permissao", Schema = Schema.SCHEMA_SEGURANCA)]
    public class Permissao : EntidadeBase
    {
        public string Nome { get; set; }

        public string Codigo { get; set; }

        public Permissao()
        {

        }
    }
}
