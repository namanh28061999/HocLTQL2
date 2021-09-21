namespace LTQLBT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.people",
                c => new
                    {
                        personID = c.String(nullable: false, maxLength: 128),
                        personName = c.String(),
                    })
                .PrimaryKey(t => t.personID);
            
            AddColumn("dbo.KhachHang", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.KhachHang", "Address");
            DropTable("dbo.people");
        }
    }
}
