namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenreIdTypeToByteInMovie : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            AddColumn("dbo.Movies", "Genre_Id1", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "Genre_Id1");
            AddForeignKey("dbo.Movies", "Genre_Id1", "dbo.Genres", "Id", cascadeDelete: true);
            DropColumn("dbo.Movies", "GenreId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Movies", "Genre_Id1", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genre_Id1" });
            DropColumn("dbo.Movies", "Genre_Id1");
            CreateIndex("dbo.Movies", "Genre_Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
