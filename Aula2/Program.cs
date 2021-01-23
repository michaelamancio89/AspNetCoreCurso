using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
           var host = new WebHostBuilder()
           .UseKestrel()
           .UseStartup<Startup>()
           .Build();

           host.Run();
        }
    }

    internal class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Use(async (context, next) => {

                await context.Response.WriteAsync("Trabalahndo com classe Startup");
            });
        }
    }
}
