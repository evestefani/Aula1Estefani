namespace RegistroDeImoveis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatTimeAtualizado : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Proprietarios", "DataDeNascimento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Proprietarios", "DataDeNascimento", c => c.Int(nullable: false));
        }
    }
}
