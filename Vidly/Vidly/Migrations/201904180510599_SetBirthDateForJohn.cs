namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetBirthDateForJohn : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate=GETDATE() WHERE Name='John Smith'");
        }
        
        public override void Down()
        {
            Sql("UPDATE Customers SET BirthDate=NULL");
        }
    }
}
