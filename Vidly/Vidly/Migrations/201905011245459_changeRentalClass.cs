namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeRentalClass : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Rentals", name: "CustomerId_Id", newName: "Customer_Id");
            RenameColumn(table: "dbo.Rentals", name: "MovieId_Id", newName: "Movie_Id");
            RenameIndex(table: "dbo.Rentals", name: "IX_CustomerId_Id", newName: "IX_Customer_Id");
            RenameIndex(table: "dbo.Rentals", name: "IX_MovieId_Id", newName: "IX_Movie_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Rentals", name: "IX_Movie_Id", newName: "IX_MovieId_Id");
            RenameIndex(table: "dbo.Rentals", name: "IX_Customer_Id", newName: "IX_CustomerId_Id");
            RenameColumn(table: "dbo.Rentals", name: "Movie_Id", newName: "MovieId_Id");
            RenameColumn(table: "dbo.Rentals", name: "Customer_Id", newName: "CustomerId_Id");
        }
    }
}
