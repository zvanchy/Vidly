namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRental : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateRented = c.DateTime(nullable: false),
                        DateReturned = c.DateTime(),
                        CustomerId_Id = c.Int(nullable: false),
                        MovieId_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId_Id, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieId_Id, cascadeDelete: true)
                .Index(t => t.CustomerId_Id)
                .Index(t => t.MovieId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "MovieId_Id", "dbo.Movies");
            DropForeignKey("dbo.Rentals", "CustomerId_Id", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] { "MovieId_Id" });
            DropIndex("dbo.Rentals", new[] { "CustomerId_Id" });
            DropTable("dbo.Rentals");
        }
    }
}
