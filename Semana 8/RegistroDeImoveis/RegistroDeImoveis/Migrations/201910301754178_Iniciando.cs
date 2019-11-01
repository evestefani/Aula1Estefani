namespace RegistroDeImoveis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Iniciando : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Imovels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Proprietario = c.String(),
                        Logradouro = c.String(),
                        Numero = c.Int(nullable: false),
                        Bairro = c.String(),
                        Complemento = c.String(),
                        Municipio = c.String(),
                        Cep = c.Int(nullable: false),
                        UF = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Proprietarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DataDeNascimento = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proprietarios");
            DropTable("dbo.Imovels");
        }
    }
}
