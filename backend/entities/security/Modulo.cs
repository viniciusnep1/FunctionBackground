using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using entities;
using core.seedwork;

namespace security
{
    [Table("modulo", Schema = Schema.SCHEMA_SEGURANCA)]
    public class Modulo : EntidadeBase
    {
        public string Nome { get; set; }

        public string Codigo { get; set; }



        public Modulo()
        {

        }

    }
}
