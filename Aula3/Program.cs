using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
           var host = WebHost
           .CreateDefaultBuilder(args)
           .UseStartup<Startup>()
           .Build();

           host.Run();
        }
    }

    internal class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
          _configuration = configuration;   
        }
        public void Configure(IApplicationBuilder app)
        {
            app.Use(async (context, next) => {

                await context.Response.WriteAsync(_configuration["Application"]);
            });
        }
    }
}
