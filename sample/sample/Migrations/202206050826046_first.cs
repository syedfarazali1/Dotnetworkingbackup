namespace sample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ORDERS",
                c => new
                    {
                        ORD_NUM = c.Int(nullable: false, identity: false),
                        ORD_AMOUNT = c.Int(nullable: false),
                        ADVANCE_AMOUNT = c.Int(nullable: false),
                        ORD_DATE = c.Int(nullable: false),
                        CUST_CODE = c.String(),
                        AGENT_CODE = c.String(),
                        ORD_DESCRIPTION = c.String(),
                    })
                .PrimaryKey(t => t.ORD_NUM);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ORDERS");
        }
    }
}
