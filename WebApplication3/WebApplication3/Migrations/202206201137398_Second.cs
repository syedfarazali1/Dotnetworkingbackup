namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ORDERS", name: "GetProduct_ID", newName: "products_ID");
            RenameIndex(table: "dbo.ORDERS", name: "IX_GetProduct_ID", newName: "IX_products_ID");
            AddColumn("dbo.ORDERS", "Name", c => c.String());
            DropColumn("dbo.ORDERS", "Document");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ORDERS", "Document", c => c.String());
            DropColumn("dbo.ORDERS", "Name");
            RenameIndex(table: "dbo.ORDERS", name: "IX_products_ID", newName: "IX_GetProduct_ID");
            RenameColumn(table: "dbo.ORDERS", name: "products_ID", newName: "GetProduct_ID");
        }
    }
}
