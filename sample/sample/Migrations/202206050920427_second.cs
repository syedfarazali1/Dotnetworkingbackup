namespace sample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ORDERS", "ORD_DATE", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ORDERS", "ORD_DATE", c => c.Int(nullable: false));
        }
    }
}
