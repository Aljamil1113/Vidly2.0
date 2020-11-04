namespace Vidly2_0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNumberAvailableMovie : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberAvailable = Stocks");
        }
        
        public override void Down()
        {
        }
    }
}
