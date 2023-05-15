using GestaoProdutos.Domain.Interfaces;
using GestaoProdutos.Domain.Interfaces.Categories.Service;
using GestaoProdutos.Domain.Interfaces.Products.Service;
using GestaoProdutos.Domain.Interfaces.Stocks.Service;
using GestaoProdutos.Domain.Services.Category;
using GestaoProdutos.Domain.Services.Product;
using GestaoProdutos.Domain.Services.Stock;
using GestaoProdutos.Infra.Data.Contexts;
using GestaoProdutos.Infra.Data.Repositories;

namespace GestaoDeProdutos.Api.Extensions
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IStockService, StockService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<DataContext>();
            return services;
        }
    }
}
