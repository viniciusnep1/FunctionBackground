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

namespace services.tests
{
    public class XptoTest
    {
       
        private static EFApplicationContext GetContextWithData()
        {
            var options = new DbContextOptionsBuilder<EFApplicationContext>()
                              .UseInMemoryDatabase(Guid.NewGuid().ToString())
                              .Options;
            var context = new EFApplicationContext(options);
            return context;
        }

        [Fact]
        public void TEST_MOCK_REPOSITORY()
        {
            var repository = new XptoRepository(GetContextWithData());
            var all = repository.GetAll().FirstOrDefaultAsync();
            Assert.NotNull(all);
        }
    }
}
