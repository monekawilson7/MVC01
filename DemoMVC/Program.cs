using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();

            var builder = WebApplication.CreateBuilder();
            //builder.Services.AddControllers(); //API
            builder.Services.AddControllersWithViews(); //MVC
            #region Configuration Services
            //builder.Services.Add<>();
            #endregion
            var app = builder.Build();
            app.UseStaticFiles();



            app.MapControllerRoute(name: "Default", 
                pattern:"{Controller=home}/{Action=index}/{id?}");

           
               app.Run();
            }

      
    }
}
