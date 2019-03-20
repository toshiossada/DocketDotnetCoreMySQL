using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace mvc1.Models {
    public static class PopulaDb {

        public static void IncluiDadosDb (IApplicationBuilder applicationBuilder) {
            IncluiDadosDb (applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext> ());
        }

        public static void IncluiDadosDb (AppDbContext context) {
            System.Console.WriteLine ("Application Migrations...");
            context.Database.Migrate ();
            if (!context.Produtos.Any ()) {
                System.Console.WriteLine ("Criando dados...");
                context.Produtos.AddRange (
                    new Produto ("Luva de goleiro", "Futebol", 25),
                    new Produto ("Bolda de Futebol", "Futebol", 50),
                    new Produto ("Meias Grandes", "Futebol", 30),
                    new Produto ("Bola de basquete", "Basquete", 50),
                    new Produto ("Cesta para quadra", "Basquete", 35)
                );

                context.SaveChanges ();
            } else {
                System.Console.WriteLine ("Já existem dados...");
            }
        }
    }
}