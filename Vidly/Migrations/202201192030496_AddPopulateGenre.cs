namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPopulateGenre : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.MovieGenres");
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropPrimaryKey("dbo.MovieGenres");
            AddColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "Genre_Id", c => c.Byte());
            AlterColumn("dbo.MovieGenres", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.MovieGenres", "Id");
            CreateIndex("dbo.Movies", "Genre_Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.MovieGenres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.MovieGenres");
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropPrimaryKey("dbo.MovieGenres");
            AlterColumn("dbo.MovieGenres", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Movies", "Genre_Id", c => c.Int());
            DropColumn("dbo.Movies", "GenreId");
            AddPrimaryKey("dbo.MovieGenres", "Id");
            CreateIndex("dbo.Movies", "Genre_Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.MovieGenres", "Id");
        }
    }
}
