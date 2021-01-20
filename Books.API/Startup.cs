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
             Transient no es una opci�n aqu�, ya que cada vez que solicita un servicio con una vida �til transitoria,
            se ofrece una nueva instancia. Eso significar�a que perder�amos
            cualquier estado que pudiera tener nuestro repositorio si lo solicitaran varias partes de nuestro c�digo.
            En otras palabras, queremos registrar un servicio de repositorio con una vida �til determinada. 
             
            //Scoped => Los objetos con �mbito son los mismos dentro de una solicitud,
            pero diferentes en diferentes solicitudes.

            //Los objetos Singleton son iguales para todos los objetos y solicitudes.

            �por qu� DbContext se registra autom�ticamente durante la vida �til del �mbito? La raz�n principal es que el
            equipo de Entity Framework Core quer�a asegurarse de que DbContext se elimine despu�s de cada solicitud.
            Si no lo hubieran hecho y lo hubieran registrado como singleton, todos los registros que alguna vez 
            se leyeron en las solicitudes ser�an rastreados por DbContext de forma predeterminada,
            lo que significa que eventualmente el rendimiento ser�a menor cuando se rastrearan m�s y m�s entidades.
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
