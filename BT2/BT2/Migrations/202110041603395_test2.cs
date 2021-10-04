namespace BT2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PerSonID = c.String(nullable: false, maxLength: 128),
                        PsName = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Description = c.String(),
                        Sex = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PerSonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
            DropTable("dbo.Accounts");
        }
    }
}
