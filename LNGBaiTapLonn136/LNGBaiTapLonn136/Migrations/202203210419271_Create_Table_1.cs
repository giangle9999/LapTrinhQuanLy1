namespace LNGBaiTapLonn136.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DangNhap",
                c => new
                    {
                        TenDangNhap = c.String(nullable: false, maxLength: 128),
                        MatKhau = c.String(),
                    })
                .PrimaryKey(t => t.TenDangNhap);
            
            CreateTable(
                "dbo.Hàng Hóa",
                c => new
                    {
                        MaHang = c.String(nullable: false, maxLength: 128),
                        TenHang = c.String(),
                        SoLuong = c.Int(nullable: false),
                        DonGia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaHang);
            
            CreateTable(
                "dbo.Nhập Kho",
                c => new
                    {
                        MaPhieuNhap = c.String(nullable: false, maxLength: 128),
                        NgayNhap = c.String(),
                        MaHang = c.String(),
                        TenHang = c.String(),
                        SoLuong = c.Int(nullable: false),
                        DonGia = c.Int(nullable: false),
                        ThanhTien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieuNhap);
            
            
            
            CreateTable(
                "dbo.Tồn Kho",
                c => new
                    {
                        MaHangTon = c.String(nullable: false, maxLength: 128),
                        TenHang = c.String(),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaHangTon);
            
            CreateTable(
                "dbo.Xuất Kho",
                c => new
                    {
                        MaPhieuXuat = c.String(nullable: false, maxLength: 128),
                        NgayXuat = c.String(),
                        MaHang = c.String(),
                        TenHang = c.String(),
                        SoLuong = c.Int(nullable: false),
                        DonGia = c.Int(nullable: false),
                        ThanhTien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieuXuat);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Xuất Kho");
            DropTable("dbo.Tồn Kho");
            DropTable("dbo.Student");
            DropTable("dbo.Nhập Kho");
            DropTable("dbo.Hàng Hóa");
            DropTable("dbo.DangNhap");
        }
    }
}
