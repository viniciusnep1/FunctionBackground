using core.seedwork;
using entities;
using entities.entity;
using System;

namespace services.repositories
{
    public class XptoRepository : Repository<Xpto, Guid>
    {
        public XptoRepository(EFApplicationContext context) : base(context)
        {

        }
    }
}
