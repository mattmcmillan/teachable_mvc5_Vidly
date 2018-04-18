namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (GenreName) VALUES ('Action')");
            Sql("INSERT INTO Genres (GenreName) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (GenreName) VALUES ('Suspense')");
            Sql("INSERT INTO Genres (GenreName) VALUES ('Musical')");
            Sql("INSERT INTO Genres (GenreName) VALUES ('Drama')");

        }

        public override void Down()
        {
        }
    }
}
