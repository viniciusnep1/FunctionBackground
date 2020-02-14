using Dapper;
using entities.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using services.repositories;
using services.services.calculos.viewModel;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace services.services.calc
{
    public class QueryVolumes
    {
        private readonly XptoRepository repository;
        private readonly IConfiguration config;


        public QueryVolumes(IConfiguration config, XptoRepository repository)
        {
            this.config = config;
            this.repository = repository;
        }

        private async Task<Xpto> UpdateValues(Xpto xptoEntity, string propriedade, string paramQuery, string column)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(config.GetConnectionString("DefaultConnection")))
            {
                conexao.Open();

                for (int i = 1; i <= 11; i++)
                {
                    var propertyName = $"{propriedade}{i}";
                    var query = $"SELECT SUM({paramQuery}{i}) FROM xpto.{column}";
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

        public async Task<Xpto> InserValues()
        {
            var xptoEntity = await repository.GetAll().FirstOrDefaultAsync();
            if (xptoEntity == null)
            {
                xptoEntity = new Xpto();

                await repository.CreateAsync(xptoEntity);
                await repository.CommitAsync();
            }

            xptoEntity = await UpdateValues(xptoEntity, "TotalProduced", "produced", "vol_produced");
            xptoEntity = await UpdateValues(xptoEntity, "TotalPlanned", "planned", "vol_planned");

            repository.Update(xptoEntity);
            try
            {
                await repository.CommitAsync();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return await Task.FromResult(xptoEntity);
        }

        public async Task<List<SumViewModel>> FillCharts()
        {
            var xptoEntity = await repository.GetAll().FirstOrDefaultAsync();

            var list = new List<SumViewModel>();

            for (int i = 1; i <= 11; i++)
            {
                var model = new SumViewModel();

                var total = GetPropValue(xptoEntity, $"TotalPlanned{i}");
                model.Planejados = (double)total;
                total = GetPropValue(xptoEntity, $"TotalProduced{i}");
                model.Produzidos = (double)total;

                list.Add(model);
            }
            return await Task.FromResult(list);
        }

        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }

    }
}
