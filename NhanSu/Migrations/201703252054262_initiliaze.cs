namespace NhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initiliaze : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChucVus",
                c => new
                    {
                        MaChucVu = c.String(nullable: false, maxLength: 30),
                        TenChucVu = c.String(),
                    })
                .PrimaryKey(t => t.MaChucVu);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 30),
                        TenNV = c.String(maxLength: 40),
                        NamSinh = c.DateTime(nullable: false),
                        GioiTinh = c.String(),
                        MaCV = c.String(maxLength: 30),
                        MaP = c.String(maxLength: 30),
                        NgayVaoCty = c.DateTime(nullable: false),
                        SDT = c.String(maxLength: 20),
                        DiaChi = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.MaNV)
                .ForeignKey("dbo.ChucVus", t => t.MaCV)
                .ForeignKey("dbo.Phongs", t => t.MaP)
                .Index(t => t.MaCV)
                .Index(t => t.MaP);
            
            CreateTable(
                "dbo.Phongs",
                c => new
                    {
                        Map = c.String(nullable: false, maxLength: 30),
                        TenP = c.String(maxLength: 30),
                        DiaChiP = c.String(maxLength: 30),
                        SDT = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Map);
            
            CreateTable(
                "dbo.Luongs",
                c => new
                    {
                        MaLuong = c.Int(nullable: false, identity: true),
                        MaNV = c.String(maxLength: 30),
                        Thuong = c.Double(nullable: false),
                        Phat = c.Double(nullable: false),
                        LuongCB = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.MaLuong)
                .ForeignKey("dbo.NhanViens", t => t.MaNV)
                .Index(t => t.MaNV);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Luongs", "MaNV", "dbo.NhanViens");
            DropForeignKey("dbo.NhanViens", "MaP", "dbo.Phongs");
            DropForeignKey("dbo.NhanViens", "MaCV", "dbo.ChucVus");
            DropIndex("dbo.Luongs", new[] { "MaNV" });
            DropIndex("dbo.NhanViens", new[] { "MaP" });
            DropIndex("dbo.NhanViens", new[] { "MaCV" });
            DropTable("dbo.Luongs");
            DropTable("dbo.Phongs");
            DropTable("dbo.NhanViens");
            DropTable("dbo.ChucVus");
        }
    }
}