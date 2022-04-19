namespace LNGBaiTapLonn136.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hàng Hóa", "TenHang", c => c.String(nullable: false));
            AlterColumn("dbo.Nhập Kho", "NgayNhap", c => c.String(nullable: false));
            AlterColumn("dbo.Nhập Kho", "MaHang", c => c.String(nullable: false));
            AlterColumn("dbo.Nhập Kho", "TenHang", c => c.String(nullable: false));
            AlterColumn("dbo.Tồn Kho", "TenHang", c => c.String(nullable: false));
            AlterColumn("dbo.Xuất Kho", "NgayXuat", c => c.String(nullable: false));
            AlterColumn("dbo.Xuất Kho", "MaHang", c => c.String(nullable: false));
            AlterColumn("dbo.Xuất Kho", "TenHang", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Xuất Kho", "TenHang", c => c.String());
            AlterColumn("dbo.Xuất Kho", "MaHang", c => c.String());
            AlterColumn("dbo.Xuất Kho", "NgayXuat", c => c.String());
            AlterColumn("dbo.Tồn Kho", "TenHang", c => c.String());
            AlterColumn("dbo.Nhập Kho", "TenHang", c => c.String());
            AlterColumn("dbo.Nhập Kho", "MaHang", c => c.String());
            AlterColumn("dbo.Nhập Kho", "NgayNhap", c => c.String());
            AlterColumn("dbo.Hàng Hóa", "TenHang", c => c.String());
        }
    }
}
