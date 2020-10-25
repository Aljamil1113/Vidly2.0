namespace Vidly2_0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (2, 'Drama')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (3, 'Horror')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (4, 'Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
