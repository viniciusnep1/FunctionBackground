using Dapper;
using entities.entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using services.repositories;
using services.services.calculos.viewModel;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace services.services.calculos
{
    public class queryVolumesPlanejadosProduzidos
    {
        private readonly XptoRepository repository;
        private readonly IConfiguration config;


        public queryVolumesPlanejadosProduzidos(IConfiguration config, XptoRepository repository)
        {
            this.config = config;
            this.repository = repository;
        }

        private static Xpto SetarValor(string nome, Xpto obj)
        {

            return obj;
        }

        private async Task<Xpto> AtualizarValores(Xpto xptoEntity, string propriedade, string parametroQuery, string coluna)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(config.GetConnectionString("DefaultConnection")))
            {
                conexao.Open();

                for (int i = 1; i <= 11; i++)
                {
                    var propertyName = $"{propriedade}{i}";
                    var query = $"SELECT SUM({parametroQuery}{i}) FROM xpto.{coluna}";
                    var somaQuery = await conexao.QueryFirstOrDefaultAsync<dynamic>(query);

                    var prop = xptoEntity.GetType().GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
                    if (null != prop && prop.CanWrite)
                    {
                        prop.SetValue(xptoEntity, somaQuery.sum, null);
                    }
                }

            }

            return await Task.FromResult(xptoEntity);
        }

        public async Task<Xpto> Calcular()
        {
            var xptoEntity = await repository.GetAll().FirstOrDefaultAsync();
            if (xptoEntity == null)
            {
                xptoEntity = new Xpto();

                await repository.CreateAsync(xptoEntity);
                await repository.CommitAsync();
            }

            xptoEntity = await AtualizarValores(xptoEntity, "TotalDadosVolProduzido", "dados_vol_produzido", "volume_produzido");
            xptoEntity = await AtualizarValores(xptoEntity, "TotalDadosVolPlanejado", "dados_vol_planejado", "volume_planejado");

            repository.Update(xptoEntity);
            await repository.CommitAsync();

            return await Task.FromResult(xptoEntity);
        }

        public async Task<List<SomatoriosViewModel>> PopularGrafico()
        {
            var xptoEntity = await repository.GetAll().FirstOrDefaultAsync();

            var lista = new List<SomatoriosViewModel>();

            for (int i = 1; i <= 11; i++)
            {
                var modelo = new SomatoriosViewModel();

                var obj = GetPropValue(xptoEntity, $"TotalDadosVolPlanejado{i}");
                modelo.Planejados = (double)obj;
                obj = GetPropValue(xptoEntity, $"TotalDadosVolProduzido{i}");
                modelo.Produzidos = (double)obj;

                lista.Add(modelo);
            }
            return await Task.FromResult(lista);
        }

        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }

    }
}
