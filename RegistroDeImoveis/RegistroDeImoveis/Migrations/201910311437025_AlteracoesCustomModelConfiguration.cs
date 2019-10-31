namespace RegistroDeImoveis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracoesCustomModelConfiguration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Imovels", "Numero", c => c.String());
            AlterColumn("dbo.Imovels", "Cep", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Imovels", "Cep", c => c.Int(nullable: false));
            AlterColumn("dbo.Imovels", "Numero", c => c.Int(nullable: false));
        }
    }
}
