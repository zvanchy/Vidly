namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Movies(Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES ('Hangover',getdate(),getdate(),12,1)");
            Sql("Insert Into Movies(Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES ('Die Hard',getdate(),getdate(),5,2)");
            Sql("Insert Into Movies(Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES ('Terminator',getdate(),getdate(),10,2)");
            Sql("Insert Into Movies(Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES ('Toy Story',getdate(),getdate(),12,3)");
            Sql("Insert Into Movies(Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES ('Titanic',getdate(),getdate(),12,4)");
        }

        public override void Down()
        {
        }
    }
}
