namespace ConsoleMigration.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleMigration.Model.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ConsoleMigration.Model.MigrationContext";
        }

        protected override void Seed(ConsoleMigration.Model.MigrationContext context)
        {
            context.Usuarios.AddOrUpdate(x => x.Nome, new Model.Usuario() {
                Nome = "Estefani",
                Login = "admin",
                Senha = "admin",
                Email = "admin@admin.com",
                Nivel = Model.Nivel.Administrador
            }) ;

            context.SaveChanges();
        }
    }
}
