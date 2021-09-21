namespace LTQLBT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtableemployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.people", "Company", c => c.String());
            AddColumn("dbo.people", "Address", c => c.String());
            AddColumn("dbo.people", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.people", "Discriminator");
            DropColumn("dbo.people", "Address");
            DropColumn("dbo.people", "Company");
        }
    }
}
