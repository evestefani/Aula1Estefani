namespace RegistroDeImoveis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProprietarioId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Imovels", "ProprietarioId", c => c.Int(nullable: false));
            DropColumn("dbo.Imovels", "Proprietario");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Imovels", "Proprietario", c => c.String());
            DropColumn("dbo.Imovels", "ProprietarioId");
        }
    }
}
