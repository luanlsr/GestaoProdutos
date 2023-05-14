using Microsoft.OpenApi.Models;
using System.Reflection;

namespace GestaoDeProdutos.Api.Extensions
{
    public static class SwaggerDocExtension
    {
        public static IServiceCollection AddDocSwagger(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "GestaoDeProdutos.API",
                    Description = "Api para gestão de produtos",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Luan da Silva Ramalho",
                        Email = "luanfswd@gmail.com",
                        Url = new Uri("http://www.github.com/luanlsr")
                    }
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                ////Adiciona os comentários do código na documentação swagger
                options.IncludeXmlComments(xmlPath);
            });
            return services;
        }

        public static IApplicationBuilder UseSwaggerDoc(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "UsersApp.API");
            });
            return app;
        }
    }
}
