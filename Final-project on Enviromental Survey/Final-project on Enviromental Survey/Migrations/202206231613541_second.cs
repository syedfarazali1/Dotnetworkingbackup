namespace Final_project_on_Enviromental_Survey.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.stdSignUps",
                c => new
                    {
                        std_SignUp_Id = c.Int(nullable: false, identity: true),
                        Student_Id = c.Int(nullable: false),
                        std_Name = c.String(nullable: false),
                        std_Father_Name = c.String(nullable: false),
                        std_Date_of_Birth = c.String(nullable: false),
                        std_password = c.String(),
                    })
                .PrimaryKey(t => t.std_SignUp_Id)
                .Index(t => t.Student_Id, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.stdSignUps", new[] { "Student_Id" });
            DropTable("dbo.stdSignUps");
        }
    }
}
