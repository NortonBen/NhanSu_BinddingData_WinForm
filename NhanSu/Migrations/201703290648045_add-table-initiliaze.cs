namespace NhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtableinitiliaze : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HopDongs",
                c => new
                    {
                        SoHD = c.String(nullable: false, maxLength: 128),
                        TenHD = c.String(nullable: false, maxLength: 50),
                        luongcb = c.Double(nullable: false),
                        phucap = c.Double(nullable: false),
                        ngayHD = c.DateTime(nullable: false),
                        ngayKT = c.DateTime(nullable: false),
                        MaNV = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.SoHD)
                .ForeignKey("dbo.NhanViens", t => t.MaNV)
                .Index(t => t.MaNV);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 10),
                        TenNV = c.String(nullable: false, maxLength: 40),
                        NamSinh = c.DateTime(nullable: false),
                        GioiTinh = c.String(nullable: false),
                        MaP = c.String(nullable: false, maxLength: 10),
                        quequan = c.String(maxLength: 50),
                        dantoc = c.String(nullable: false, maxLength: 60),
                        ngoaingu = c.String(nullable: false, maxLength: 60),
                        trinhdo = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.MaNV)
                .ForeignKey("dbo.Phongs", t => t.MaP, cascadeDelete: true)
                .Index(t => t.MaP);
            
            CreateTable(
                "dbo.Phongs",
                c => new
                    {
                        Map = c.String(nullable: false, maxLength: 10),
                        TenP = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Map);
            
            CreateTable(
                "dbo.QuyetDinhs",
                c => new
                    {
                        SoQD = c.String(nullable: false, maxLength: 10),
                        TenQD = c.String(maxLength: 30),
                        NoiDung = c.String(nullable: false),
                        ngayQD = c.DateTime(nullable: false),
                        MaNV = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.SoQD)
                .ForeignKey("dbo.NhanViens", t => t.MaNV)
                .Index(t => t.MaNV);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        email = c.String(maxLength: 20),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuyetDinhs", "MaNV", "dbo.NhanViens");
            DropForeignKey("dbo.NhanViens", "MaP", "dbo.Phongs");
            DropForeignKey("dbo.HopDongs", "MaNV", "dbo.NhanViens");
            DropIndex("dbo.QuyetDinhs", new[] { "MaNV" });
            DropIndex("dbo.NhanViens", new[] { "MaP" });
            DropIndex("dbo.HopDongs", new[] { "MaNV" });
            DropTable("dbo.Users");
            DropTable("dbo.QuyetDinhs");
            DropTable("dbo.Phongs");
            DropTable("dbo.NhanViens");
            DropTable("dbo.HopDongs");
        }
    }
}
