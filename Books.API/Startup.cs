using AutoMapper;
using Books.Api;
using Books.Api.Contexts;
using Books.Api.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();


            //Console: Add-Migration InitialMigration
            var connectionString = Configuration["ConnectionStrings:BooksDBConnectionString"];
            services.AddDbContext<BooksContext>(o =>
            {
                o.UseSqlServer(connectionString);
            });

            /*
             * 
             * Los objetos transitorios siempre son diferentes; Se proporciona una nueva instancia 
             * a cada controlador y cada servicio.
             * 
             Transient no es una opción aquí, ya que cada vez que solicita un servicio con una vida útil transitoria,
            se ofrece una nueva instancia. Eso significaría que perderíamos
            cualquier estado que pudiera tener nuestro repositorio si lo solicitaran varias partes de nuestro código.
            En otras palabras, queremos registrar un servicio de repositorio con una vida útil determinada. 
             
            //Scoped => Los objetos con ámbito son los mismos dentro de una solicitud,
            pero diferentes en diferentes solicitudes.

            //Los objetos Singleton son iguales para todos los objetos y solicitudes.

            ¿por qué DbContext se registra automáticamente durante la vida útil del ámbito? La razón principal es que el
            equipo de Entity Framework Core quería asegurarse de que DbContext se elimine después de cada solicitud.
            Si no lo hubieran hecho y lo hubieran registrado como singleton, todos los registros que alguna vez 
            se leyeron en las solicitudes serían rastreados por DbContext de forma predeterminada,
            lo que significa que eventualmente el rendimiento sería menor cuando se rastrearan más y más entidades.
             */
            services.AddScoped<IBooksRepository, BooksRepository>();

            services.AddAutoMapper(typeof(BooksProfile));
            
            //Si llamamos a los servicios externos, necesitamos HTTPCLIENT
            services.AddHttpClient();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
