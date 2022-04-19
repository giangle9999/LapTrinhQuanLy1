namespace LNGBaiThucHanhh136.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_1 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Account");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Username);
            
        }
    }
}
