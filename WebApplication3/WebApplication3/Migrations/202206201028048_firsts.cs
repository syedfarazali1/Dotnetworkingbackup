namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firsts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Custome_signin",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ORDERS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Images = c.String(),
                        Document = c.String(),
                        audio = c.String(),
                        video = c.String(),
                        GetProduct_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.GetProduct_ID)
                .Index(t => t.GetProduct_ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Owner_signin",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ORDERS", "GetProduct_ID", "dbo.Products");
            DropIndex("dbo.ORDERS", new[] { "GetProduct_ID" });
            DropTable("dbo.Owner_signin");
            DropTable("dbo.Products");
            DropTable("dbo.ORDERS");
            DropTable("dbo.Custome_signin");
        }
    }
}
