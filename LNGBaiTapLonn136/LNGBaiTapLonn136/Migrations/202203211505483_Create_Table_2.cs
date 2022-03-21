namespace LNGBaiTapLonn136.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Username);
            
            DropTable("dbo.Student");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 50),
                        StudentName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.StudentID);
            
            DropTable("dbo.Accounts");
        }
    }
}
