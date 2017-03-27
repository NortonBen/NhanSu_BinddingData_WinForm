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
                        TenChucVu = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.MaChucVu);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 30),
                        TenNV = c.String(nullable: false, maxLength: 40),
                        NamSinh = c.DateTime(nullable: false),
                        GioiTinh = c.String(nullable: false),
                        MaCV = c.String(maxLength: 30),
                        MaP = c.String(nullable: false, maxLength: 30),
                        NgayVaoCty = c.DateTime(nullable: false),
                        SDT = c.String(nullable: false, maxLength: 20),
                        DiaChi = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.MaNV)
                .ForeignKey("dbo.ChucVus", t => t.MaCV)
                .ForeignKey("dbo.Phongs", t => t.MaP, cascadeDelete: true)
                .Index(t => t.MaCV)
                .Index(t => t.MaP);
            
            CreateTable(
                "dbo.Phongs",
                c => new
                    {
                        Map = c.String(nullable: false, maxLength: 30),
                        TenP = c.String(nullable: false, maxLength: 30),
                        DiaChiP = c.String(nullable: false, maxLength: 30),
                        SDT = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Map);
            
            CreateTable(
                "dbo.Luongs",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 30),
                        heso = c.Double(nullable: false),
                        LuongCB = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.MaNV)
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
