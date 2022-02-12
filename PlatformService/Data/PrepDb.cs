using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        //Setup the Database context
        // 0) Class for testing
        // 1) We cannot use ctor DI with static class
        // 2) used for Migrations
        public static void PrepPopulation(IApplicationBuilder app, bool isProd)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>(), isProd);
            }

        }

        private static void SeedData(AppDbContext context, bool isProd)
        {
            if(isProd)
            {
                Console.WriteLine("--> Atempting to aply migration... ");
                try
                {
                    context.Database.Migrate();
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine($"--> Could not run migrations: {ex.Message}");
                }
            }

            if(!context.Platforms.Any())
            {
                Console.WriteLine("--> Seeding Data... ");

                context.Platforms.AddRange(
                    new Platform() {Name = "Dot Net", Publisher = "Microsoft", Cost = "Free"},
                    new Platform() {Name = "Sql Server Express", Publisher = "Microsoft", Cost = "Free"},
                    new Platform() {Name = "Kubernetes", Publisher = "cloud Native Computing Foundation", Cost = "Free"}
                );

                context.SaveChanges(); // Do not forget
            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}