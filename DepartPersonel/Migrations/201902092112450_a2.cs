namespace DepartPersonel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Departman", newName: "Departmanlar");
            RenameTable(name: "dbo.Personel", newName: "Personeller");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Personeller", newName: "Personel");
            RenameTable(name: "dbo.Departmanlar", newName: "Departman");
        }
    }
}
