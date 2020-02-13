using core.seedwork;
using entities;
using entities.entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace services.repositories
{
    public class XptoRepository : Repository<Xpto, Guid>
    {
        public XptoRepository(EFApplicationContext context) : base(context)
        {

        }
    }
}
