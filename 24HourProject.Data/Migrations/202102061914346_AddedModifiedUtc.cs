namespace _24HourProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedModifiedUtc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Post", "ModifiedUtc", c => c.DateTimeOffset(precision: 7));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Post", "ModifiedUtc");
        }
    }
}
