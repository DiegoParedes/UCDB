namespace UCDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicializando_classe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pedidos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeProduto = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Vencimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pedidos");
        }
    }
}
