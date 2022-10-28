namespace RishtaWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_tbls : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tbl_Profile", "DOB", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tbl_Profile", "DOB", c => c.DateTime(nullable: false));
        }
    }
}
