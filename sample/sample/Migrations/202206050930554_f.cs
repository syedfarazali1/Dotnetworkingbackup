namespace sample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ORDERS");
            AlterColumn("dbo.ORDERS", "ORD_NUM", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ORDERS", "ORD_AMOUNT", c => c.String());
            AlterColumn("dbo.ORDERS", "ADVANCE_AMOUNT", c => c.String());
            AddPrimaryKey("dbo.ORDERS", "ORD_NUM");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ORDERS");
            AlterColumn("dbo.ORDERS", "ADVANCE_AMOUNT", c => c.Int(nullable: false));
            AlterColumn("dbo.ORDERS", "ORD_AMOUNT", c => c.Int(nullable: false));
            AlterColumn("dbo.ORDERS", "ORD_NUM", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ORDERS", "ORD_NUM");
        }
    }
}
