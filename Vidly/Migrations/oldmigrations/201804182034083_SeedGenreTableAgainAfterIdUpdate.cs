namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedGenreTableAgainAfterIdUpdate : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Suspense')");
            Sql("INSERT INTO Genres (Name) VALUES ('Musical')");
            Sql("INSERT INTO Genres (Name) VALUES ('Drama')");
        }

        public override void Down()
        {
        }
    }
}
