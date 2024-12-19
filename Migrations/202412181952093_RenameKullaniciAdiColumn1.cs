namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameKullaniciAdiColumn1 : DbMigration
    {
        public override void Up()
        {
           
            AddColumn("dbo.Yorumlars", "KullaniciAdi", c => c.String()); // Yeni kolon adı
        }
        
        public override void Down()
        {
            
            DropColumn("dbo.Yorumlars", "KullaniciAdi"); // Yeni kolon adı
        }
    }
}
