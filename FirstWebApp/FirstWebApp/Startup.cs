using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace FirstWebApp
{
    public class Startup
    {
        private string text;

        public Startup()
        {
            this.text = "Reshmi";
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.Run(async (context) => { await context.Response.WriteAsync(
            $"<h1 onclick=alert('{this.text}')>Welcome {this.text}</h1>"); });
        }
    }
}