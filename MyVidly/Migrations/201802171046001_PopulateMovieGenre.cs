namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (3, 'Superhero')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (4, 'Drama')");
        }
        
        public override void Down()
        {
        }
    }
}
