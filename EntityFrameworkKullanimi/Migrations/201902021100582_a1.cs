namespace EntityFrameworkKullanimi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Uruns", "Kategori_Id", "dbo.Kategoris");
            DropIndex("dbo.Uruns", new[] { "Kategori_Id" });
            RenameColumn(table: "dbo.Uruns", name: "Kategori_Id", newName: "KategoriId");
            AlterColumn("dbo.Uruns", "Fiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Uruns", "Stok", c => c.Int(nullable: false));
            AlterColumn("dbo.Uruns", "KategoriId", c => c.Int(nullable: false));
            CreateIndex("dbo.Uruns", "KategoriId");
            AddForeignKey("dbo.Uruns", "KategoriId", "dbo.Kategoris", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Uruns", "KategoriId", "dbo.Kategoris");
            DropIndex("dbo.Uruns", new[] { "KategoriId" });
            AlterColumn("dbo.Uruns", "KategoriId", c => c.Int());
            AlterColumn("dbo.Uruns", "Stok", c => c.String());
            AlterColumn("dbo.Uruns", "Fiyat", c => c.String());
            RenameColumn(table: "dbo.Uruns", name: "KategoriId", newName: "Kategori_Id");
            CreateIndex("dbo.Uruns", "Kategori_Id");
            AddForeignKey("dbo.Uruns", "Kategori_Id", "dbo.Kategoris", "Id");
        }
    }
}
