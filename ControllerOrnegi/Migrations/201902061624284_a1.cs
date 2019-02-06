namespace ControllerOrnegi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fakulte",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FakulteAd = c.String(nullable: false),
                        SilindiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fakulte");
        }
    }
}
