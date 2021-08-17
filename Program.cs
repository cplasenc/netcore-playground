using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using System;

namespace Demo_launch_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var hostBuilder = Host.CreateDefaultBuilder(args)
                                    .ConfigureWebHostDefaults(b =>
                                    {
                                        b.UseStartup<Program>();
                                    });
            var host = hostBuilder.Build();
            host.Run();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync($"Hi! We are in {env.EnvironmentName}");
            });
        }
    }
}
