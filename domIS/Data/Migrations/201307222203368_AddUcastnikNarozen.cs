namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUcastnikNarozen : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ucastniks", "Narozen", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ucastniks", "Narozen");
        }
    }
}
