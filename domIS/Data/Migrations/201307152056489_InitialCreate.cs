namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ucastniks",
                c => new
                    {
                        UcastnikId = c.Int(nullable: false, identity: true),
                        Jmeno = c.String(maxLength: 4000),
                        Prijmeni = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.UcastnikId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ucastniks");
        }
    }
}
