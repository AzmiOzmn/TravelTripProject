namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameKullaniciAdiColumn : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Yorumlars", "Blog_ID", "dbo.Blogs");
            DropIndex("dbo.Yorumlars", new[] { "Blog_ID" });
            RenameColumn(table: "dbo.Yorumlars", name: "Blog_ID", newName: "Blogid");
            
            AlterColumn("dbo.Yorumlars", "Blogid", c => c.Int(nullable: false));
            CreateIndex("dbo.Yorumlars", "Blogid");
            AddForeignKey("dbo.Yorumlars", "Blogid", "dbo.Blogs", "ID", cascadeDelete: true);
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.Yorumlars", "KullaniciAdı", c => c.String());
            DropForeignKey("dbo.Yorumlars", "Blogid", "dbo.Blogs");
            DropIndex("dbo.Yorumlars", new[] { "Blogid" });
            AlterColumn("dbo.Yorumlars", "Blogid", c => c.Int());
            
            RenameColumn(table: "dbo.Yorumlars", name: "Blogid", newName: "Blog_ID");
            CreateIndex("dbo.Yorumlars", "Blog_ID");
            AddForeignKey("dbo.Yorumlars", "Blog_ID", "dbo.Blogs", "ID");
        }
    }
}
