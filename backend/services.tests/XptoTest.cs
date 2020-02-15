using System;
using Xunit;
using entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using services.repositories;
using services.services.calc;
using Moq;
using services.services.calculos.viewModel;
using System.Threading.Tasks;
using entities.entity;

namespace services.tests
{
    public class XptoTest
    {
       
        [Fact]
        public void TEST_MOCK_REPOSITORY()
        {
            var options = new DbContextOptionsBuilder<EFApplicationContext>()
                             .UseInMemoryDatabase("portal_xpto")
                             .Options;

            using (var context = new EFApplicationContext(options))
            {
                context.XptoSet.Add(new Xpto { Id = Guid.NewGuid() });
                context.XptoSet.Add(new Xpto { Id = Guid.NewGuid() });
                context.SaveChanges();
            }

            using (var context = new EFApplicationContext(options))
            {
                var service = new XptoRepository(context);
                var result = service.GetAll().ToList();
                Assert.NotNull(result);
            }
        }
    }
}
