namespace LTQLBT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_KhachHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        idKhachHang = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenKhachHang = c.String(),
                        SodienThoai = c.String(maxLength: 11, unicode: false),
                    })
                .PrimaryKey(t => t.idKhachHang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHang");
        }
    }
}
