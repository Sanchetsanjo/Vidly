namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenere : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1,'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2,'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3,'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4,'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5,'Scifi')");
        }
        
        public override void Down()
        {
        }
    }
}
