namespace RishtaWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_tbl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tbl_Profile",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Height_education = c.String(),
                        Work_with = c.String(),
                        Job_Role = c.String(),
                        Income = c.String(),
                        Profile_For = c.String(),
                        F_Name = c.String(),
                        L_Name = c.String(),
                        Gender = c.String(),
                        Religion = c.String(),
                        Community = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Country = c.String(),
                        City = c.String(),
                        With_Fam = c.String(),
                        Mar_Status = c.String(),
                        Diet = c.String(),
                        Height = c.String(),
                        Cast = c.String(),
                        About_Urself = c.String(),
                        Ph_No = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Confrim_Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tbl_Profile");
        }
    }
}
